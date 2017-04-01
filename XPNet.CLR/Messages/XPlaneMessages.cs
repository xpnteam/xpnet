using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet
{
    public class XPMessageEventArgs : EventArgs
    {
        public XPMessageEventArgs(int sentFromPluginId, int messageId, IntPtr parameter)
        {
            SentFromPluginId = sentFromPluginId;
            MessageId = messageId;
            Parameter = parameter;
        }

        public int SentFromPluginId { get; }

        public int MessageId { get; }

        public IntPtr Parameter { get; }
    }

    public class XPPlaneMessageEventArgs : XPMessageEventArgs
    {
        public XPPlaneMessageEventArgs(int sentFromPluginId, int messageId, IntPtr parameter)
            : base(sentFromPluginId, messageId, parameter)
        { }

        public int PlaneNumber
        {
            get { return Parameter.ToInt32(); }
        }
    }

    public class XPAirportMessageEventArgs : XPMessageEventArgs
    {
        public XPAirportMessageEventArgs(int sentFromPluginId, int messageId, IntPtr parameter)
            : base(sentFromPluginId, messageId, parameter)
        { }

        public int AirportNumber
        {
            get { return Parameter.ToInt32(); }
        }
    }

    /// <summary>
    /// Defines the Messaging API.
    /// </summary>
    public interface IXPlaneMessages
    {
        // TODO: Map XPLMSendMessageToPlugin.

        /// <summary>
        /// Raised when the user's plane crashes.
        /// </summary>
        event EventHandler<XPMessageEventArgs> PlaneCrashed;

        /// <summary>
        /// Raised when a plane has loaded.  The PlaneNumber parameter
        /// indicates which plane was loaded.  0 indicates the user's plane.
        /// </summary>
        event EventHandler<XPPlaneMessageEventArgs> PlaneLoaded;

        /// <summary>
        /// Raised when a plane has unloaded.  The PlaneNumber parameter
        /// indicates which plane was unloaded.  0 indicates the user's plane.
        /// </summary>
        event EventHandler<XPPlaneMessageEventArgs> PlaneUnloaded;

        /// <summary>
        /// Raised right after livery is loaded for an airplane.  Use Data to
        /// find information about the livery.    The PlaneNumber parameter
        /// indicates which plane was unloaded.  0 indicates the user's plane.
        /// </summary>
        event EventHandler<XPPlaneMessageEventArgs> LiveryLoaded;

        /// <summary>
        /// Raised when the user's plane is positioned at a new airport.
        /// </summary>
        event EventHandler<XPAirportMessageEventArgs> AirportLoaded;

        /// <summary>
        /// Raised when new scenery is loaded.  Use Data to discover the
        /// new scenery files that were loaded.
        /// </summary>
        event EventHandler<XPMessageEventArgs> SceneryLoaded;

        /// <summary>
        /// Raised when the user adjusts the number of X-Plane aircraft models.
        /// </summary>
        event EventHandler<XPMessageEventArgs> AirplaneCountChanged;

        /// <summary>
        /// Raised right before X-Plane writes its preferences file.  You can
        /// use this for two purposes: to write your own preferences, and to
        /// modify any datarefs to influence preferences output. For example,
        /// if your plugin temporarily modifies saved preferences, you can put
        /// them back to their default values here to avoid having the tweaks
        /// be persisted if your plugin is not loaded on the next invocation
        /// of X-Plane.
        /// </summary>
        event EventHandler<XPMessageEventArgs> WillWritePreferences;

        /// <summary>
        /// Raised whenever any message is received.
        /// </summary>
        /// <remarks>
        /// For consistency and to avoid subtle bugs as new messages come into
        /// the X-Plane API over time, this event is raised both for known
        /// message types and unknown ones.
        /// </remarks>
        event EventHandler<XPMessageEventArgs> MessageReceived;
    }

    public class XPlaneMessages : IXPlaneMessages
    {
        public event EventHandler<XPMessageEventArgs> PlaneCrashed;

        public event EventHandler<XPPlaneMessageEventArgs> PlaneLoaded;

        public event EventHandler<XPPlaneMessageEventArgs> PlaneUnloaded;

        public event EventHandler<XPPlaneMessageEventArgs> LiveryLoaded;

        public event EventHandler<XPAirportMessageEventArgs> AirportLoaded;

        public event EventHandler<XPMessageEventArgs> SceneryLoaded;

        public event EventHandler<XPMessageEventArgs> AirplaneCountChanged;

        public event EventHandler<XPMessageEventArgs> WillWritePreferences;

        public event EventHandler<XPMessageEventArgs> MessageReceived;

        internal unsafe void RaiseMessage(int fromPluginId, int msg, void* inParam)
        {
            switch (msg)
            {
                case 101: // XPLM_MSG_PLANE_CRASHED
                    PlaneCrashed?.Invoke(this, new XPMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                case 102: // XPLM_MSG_PLANE_LOADED
                    PlaneLoaded?.Invoke(this, new XPPlaneMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                case 106: // XPLM_MSG_PLANE_UNLOADED
                    PlaneUnloaded?.Invoke(this, new XPPlaneMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                case 103: // XPLM_MSG_AIRPORT_LOADED
                    AirportLoaded?.Invoke(this, new XPAirportMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                case 104: // XPLM_MSG_SCENERY_LOADED
                    SceneryLoaded?.Invoke(this, new XPMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                case 105: // XPLM_MSG_AIRPLANE_COUNT_CHANGED
                    AirplaneCountChanged?.Invoke(this, new XPMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                case 107: // XPLM_MSG_WILL_WRITE_PREFS
                    WillWritePreferences?.Invoke(this, new XPMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                case 108: // XPLM_MSG_LIVERY_LOADED
                    LiveryLoaded?.Invoke(this, new XPPlaneMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    goto default;

                default:
                    MessageReceived?.Invoke(this, new XPMessageEventArgs(fromPluginId, msg, (IntPtr)inParam));
                    break;
            }
        }
    }
}
