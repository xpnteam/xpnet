
using System;

namespace XPNet
{
    /// <summary>
    /// Delegate for C# code that wants to be called as part of the flight loop.
    /// </summary>
    public delegate FlightLoopTime FlightLoopDelegate(
        TimeSpan elapsedTimeSinceLastCall,
        TimeSpan elapsedTimeSinceLastFlightLoop,
        int counter
    );

    /// <summary>
    /// Provides access to the X-Plane processing API, which allows you to be notified
    /// when certain events occur, since as when the simulation is periodically integrated.
    /// </summary>
    public interface IXPlaneProcessing
    {
        /// <summary>
        /// Gets the elapsed time since the simulation started in decimal seconds.
        /// </summary>
        TimeSpan ElapsedTime { get; }

        /// <summary>
        /// Gets the value of a counter that starts at zero for each sim cycle computed / video frame rendered.
        /// </summary>
        int CycleNumber { get; }

        /// <summary>
        /// Register a flight loop hook with X-Plane.  Interact with the resulting object
        /// to be notified of flight loop hook events.  Dispose of the resulting object
        /// if you no longer want to be notified of flight loop events.
        /// </summary>
        IXPFlightLoopHook RegisterFlightLoopHook(FlightLoopTime initialSchedule, FlightLoopDelegate loopDelegate);
    }

    /// <summary>
    /// Represents flight loop time in X-Plane.
    /// </summary>
    public struct FlightLoopTime
    {
        public static readonly FlightLoopTime Unscheduled = new FlightLoopTime();

        private readonly float m_time;

        internal FlightLoopTime(float time)
        {
            m_time = time;
        }

        internal float Time
        {
            get { return m_time; }
        }

        /// <summary>
        /// Creates a <see cref="FlightLoopTime"/> from a <see cref="TimeSpan"/>.
        /// </summary>
        public static implicit operator FlightLoopTime(TimeSpan ts)
        {
            return FlightLoopTime.FromSeconds((float)ts.TotalSeconds);
        }

        /// <summary>
        /// Returns a time that indicates a flight loop delegate scheduled to be called
        /// some number of seconds in the future.
        /// </summary>
        public static FlightLoopTime FromSeconds(float nSeconds)
        {
            if (nSeconds < 0)
                throw new InvalidOperationException("nSeconds must be greater than or equal to 0.");

            return new FlightLoopTime(nSeconds);
        }

        /// <summary>
        /// Returns a time that indicates a flight loop delegate scheduled to be called
        /// some number of X-Plane cycles in the future.
        /// </summary>
        public static FlightLoopTime FromCycles(int nCycles)
        {
            if (nCycles < 0)
                throw new InvalidOperationException("nCycles must be greater than or equal to 0.");

            return new FlightLoopTime(-nCycles);
        }
    }

    /// <summary>
    /// Represents a hook into the X-Plane flight loop.
    /// </summary>
    public interface IXPFlightLoopHook : IDisposable
    {
        /// <summary>
        /// Sets the scheduling interval for the flight loop.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Pass <see cref="FlightLoopTime.Unscheduled"/> to disable the loop.  Disabling the
        /// loop does not unregister it, it just stops it from being called until you reenable
        /// it by calling this method again with a different parameter.
        /// </para>
        /// <para>
        /// Calling this method from within your loop delegate is an invalid operation.  You
        /// change the schedule from within the loop delegate via the loop delegate's return
        /// value.
        /// </para>
        /// </remarks>
        /// <param name="time">
        /// The time you want the loop to next be scheduled.
        /// </param>
        /// <param name="relativeToNow">
        /// If true, <paramref name="time"/> will be interpreted from the time of this call;
        /// otherwise it will be interpreted from the last time the loop delegate was called,
        /// or the time it was registered if it has never been called.
        /// </param>
        void SetInterval(FlightLoopTime time, bool relativeToNow);
    }

    internal class XPlaneProcessing : IXPlaneProcessing
    {
        public TimeSpan ElapsedTime => TimeSpan.FromSeconds(PluginBridge.ApiFunctions.XPLMGetElapsedTime());

        public int CycleNumber => PluginBridge.ApiFunctions.XPLMGetCycleNumber();

        public IXPFlightLoopHook RegisterFlightLoopHook(FlightLoopTime initialSchedule, FlightLoopDelegate loopDelegate)
        {
            return new XPFlightLoopHook(initialSchedule, loopDelegate);
        }
    }

    internal class XPFlightLoopHook : IXPFlightLoopHook
    {
        private readonly FlightLoopDelegate m_loopDelegate;
        private readonly XPLMFlightLoop_f m_hookDelegate;

        private bool m_inLoopDelegate;

        public unsafe XPFlightLoopHook(FlightLoopTime initialSchedule, FlightLoopDelegate loopDelegate)
        {
            m_loopDelegate = loopDelegate;
            m_hookDelegate = new XPLMFlightLoop_f(XPLMFlightHookCallback);

            PluginBridge.ApiFunctions.XPLMRegisterFlightLoopCallback(m_hookDelegate, initialSchedule.Time, inRefcon: null);
        }

        public unsafe void Dispose()
        {
            PluginBridge.ApiFunctions.XPLMUnregisterFlightLoopCallback(m_hookDelegate, inRefcon: null);
        }

        public unsafe void SetInterval(FlightLoopTime time, bool relativeToNow)
        {
            if (m_inLoopDelegate)
                throw new InvalidOperationException("Interval must not be set from within the loop delegate.  Change the interval within the loop delegate using the delegate's return value instead.");

            PluginBridge.ApiFunctions.XPLMSetFlightLoopCallbackInterval(
                m_hookDelegate, time.Time, inRelativeToNow: relativeToNow ? 1 : 0, inRefcon: null
            );
        }

        private unsafe float XPLMFlightHookCallback(
            float inElapsedSinceLastCall,
            float inElapsedTimeSinceLastFlightLoop,
            int inCounter,
            void* inRefcon)
        {
            try
            {
                m_inLoopDelegate = true;

                var ret = m_loopDelegate(
                    TimeSpan.FromSeconds(inElapsedSinceLastCall),
                    TimeSpan.FromSeconds(inElapsedTimeSinceLastFlightLoop),
                    inCounter
                ).Time;

                return ret;
            }
            catch (Exception exc)
            {
                PluginBridge.Log.Log(exc);
                PluginBridge.Log.Log("XPNet CLR: Flight hook will be set to unscheduled due to exception above.");

                return 0;
            }
            finally
            {
                m_inLoopDelegate = false;
            }
        }
    }
}
