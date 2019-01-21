using System;
using System.Collections.Generic;
using System.Text;
using XPNet.Data;

namespace XPNet
{
    /// <summary>
    /// Provides access to X-Plane Datarefs.  Datarefs are how you read and write data
    /// to and from X-Plane, such as airplane position, COM radio frequences, etc.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Looking up a dataref in X-Plane is much more expensive than reading and writing it,
    /// so you are encouraged to look up the datarefs you'll be using once, and then use
    /// the resulting lookup token for all subsequent access.  The XPNet API supports that
    /// mode of operation, and that is the recommended way to do things.  To cache a dataref
    /// in XPNet, do something like the following:
    /// </para>
    /// <code>
    /// var refSimDatarefsY = api.Data.Sim.FlightModel.Position.LocalY;
    /// // - or, for any generic dataref -
    /// var refY = api.Data.GetFloat("sim/flightmodel/position/local_y");
    /// </code>
    /// <para>
    /// You'd normally put code like the above in your plugin constructor or other run-once
    /// part of the code, and keep then put refX or refY into a member variable to use from
    /// then on.
    /// </para>
    /// <para>
    /// Additionally, this API automatically
    /// caches dataref lookups once they are done one time, so additional requests incur only
    /// the cost of a hashtable lookup.  That makes the API relatively performant even if you
    /// don't always cache your data accessors.  In general, cache your data accessors, but if
    /// you're writing code that must be generic (i.e., you don't know ahead of time which
    /// datarefs you'll be reading, such as if you are interfacing with hardware that is making
    /// its own dataref decisions), or for code that doesn't run on every frame loop and is
    /// not performance-critical, this API will make those operations only slightly more
    /// expensive, since hash lookups are fast.
    /// </para>
    /// </remarks>
    public interface IXPlaneData
    {
        // TODO: Support for publishing our own datarefs.
        // ENHANCE: Support for many, many more fluent datarefs, if that capability
        // proves useful.  I have just put a relative handful in here just as
        // a proof of concept for the feature.

        /// <summary>
        /// Returns true if the current X-Plane engine has an int dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        bool IntDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has an int array dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        bool IntArrayDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has a bool dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        /// <remarks>
        /// This does only minimal type checking.  You can treat an int as a bool and a bool
        /// as an int.
        /// </remarks>
        bool BoolDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has a bool array dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        /// <remarks>
        /// This does only minimal type checking.  You can treat an int as a bool and a bool
        /// as an int.
        /// </remarks>
        bool BoolArrayDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has a float dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        bool FloatDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has a float array dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        bool FloatArrayDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has a double dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        bool DoubleDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has a byte array dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        bool ByteArrayDataExists(string dataRefName);

        /// <summary>
        /// Returns true if the current X-Plane engine has a string dataref with the given
        /// identifier, false otherwise.
        /// </summary>
        /// <remarks>
        /// This does only minimal type checking.  This will return true if the given dataref
        /// exists and is an array type even if it is meant to be interpreted as something other
        /// than a string.  See the X-Plane dataref docs to discover which datarefs are actually
        /// strings.
        /// </remarks>
        bool StringDataExists(string dataRefName);

        /// <summary>
        /// Gets an int dataref accessor by name.
        /// </summary>
        IXPDataRef<int> GetInt(string dataRefName);

        /// <summary>
        /// Gets an int array dataref accessor by name.
        /// </summary>
        IXPDataRef<int[]> GetIntArray(string dataRefName);

        /// <summary>
        /// Gets a bool dataref accessor by name.
        /// </summary>
        IXPDataRef<bool> GetBool(string dataRefName);

        /// <summary>
        /// Gets a bool array dataref accessor by name.
        /// </summary>
        IXPDataRef<bool[]> GetBoolArray(string dataRefName);

        /// <summary>
        /// Gets a float dataref accessor by name.
        /// </summary>
        IXPDataRef<float> GetFloat(string dataRefName);

        /// <summary>
        /// Gets a float array dataref accessor by name.
        /// </summary>
        IXPDataRef<float[]> GetFloatArray(string dataRefName);

        /// <summary>
        /// Gets a double dataref accessor by name.
        /// </summary>
        IXPDataRef<double> GetDouble(string dataRefName);

        /// <summary>
        /// Gets a string dataref accessor by name.
        /// </summary>
        IXPDataRef<string> GetString(string dataRefName);

        /// <summary>
        /// Gets a byte array dataref accessor by name.
        /// </summary>
        IXPDataRef<byte[]> GetByteArray(string dataRefName);

        /// <summary>
        /// Gets the set of 'sim' named datarefs.
        /// </summary>
        SimDataRefs Sim { get; }
    }

    internal class XPlaneData : IXPlaneData
    {
        // MAINT: Whenever we add support for registering DataRefs from XPNet,
        // then we are also responsible for unregistering them when plugins are
        // unloaded; consider whether bulk-unregistering them here for that
        // case would be appropriate, or whether the plugin class should always
        // be responsible for that.

        private readonly Dictionary<string, IXPDataRef<int>> m_intRefs
            = new Dictionary<string, IXPDataRef<int>>();
        private readonly Dictionary<string, IXPDataRef<int[]>> m_intArrayRefs
            = new Dictionary<string, IXPDataRef<int[]>>();
        private readonly Dictionary<string, IXPDataRef<bool>> m_boolRefs
            = new Dictionary<string, IXPDataRef<bool>>();
        private readonly Dictionary<string, IXPDataRef<bool[]>> m_boolArrayRefs
            = new Dictionary<string, IXPDataRef<bool[]>>();
        private readonly Dictionary<string, IXPDataRef<float>> m_floatRefs
            = new Dictionary<string, IXPDataRef<float>>();
        private readonly Dictionary<string, IXPDataRef<float[]>> m_floatArrayRefs
            = new Dictionary<string, IXPDataRef<float[]>>();
        private readonly Dictionary<string, IXPDataRef<double>> m_doubleRefs
            = new Dictionary<string, IXPDataRef<double>>();
        private readonly Dictionary<string, IXPDataRef<byte[]>> m_byteArrayRefs
            = new Dictionary<string, IXPDataRef<byte[]>>();
        private readonly Dictionary<string, IXPDataRef<string>> m_stringRefs
            = new Dictionary<string, IXPDataRef<string>>();

        private unsafe delegate IXPDataRef<T> DataRefFactory<T>(string dataRefName, void* dataref);

        private readonly SimDataRefs m_sim;

        public XPlaneData()
        {
            m_sim = new SimDataRefs(this);
        }

        public SimDataRefs Sim => m_sim;

        public unsafe IXPDataRef<int> GetInt(string dataRefName) =>
            GetDataRef(dataRefName, m_intRefs, CreateDataRefInt, XPDataTypes.Int) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<int[]> GetIntArray(string dataRefName) =>
            GetDataRef(dataRefName, m_intArrayRefs, CreateDataRefIntArray, XPDataTypes.IntArray) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<bool> GetBool(string dataRefName) =>
            GetDataRef(dataRefName, m_boolRefs, CreateDataRefBool, XPDataTypes.Int) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<bool[]> GetBoolArray(string dataRefName) =>
            GetDataRef(dataRefName, m_boolArrayRefs, CreateDataRefBoolArray, XPDataTypes.IntArray) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<float> GetFloat(string dataRefName) =>
            GetDataRef(dataRefName, m_floatRefs, CreateDataRefFloat, XPDataTypes.Float) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<float[]> GetFloatArray(string dataRefName) =>
            GetDataRef(dataRefName, m_floatArrayRefs, CreateDataRefFloatArray, XPDataTypes.FloatArray) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<double> GetDouble(string dataRefName) =>
            GetDataRef(dataRefName, m_doubleRefs, CreateDataRefDouble, XPDataTypes.Double) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<byte[]> GetByteArray(string dataRefName) =>
            GetDataRef(dataRefName, m_byteArrayRefs, CreateDataRefByteArray, XPDataTypes.Data) ?? throw InvalidDataRefException(dataRefName);

        public unsafe IXPDataRef<string> GetString(string dataRefName) =>
            GetDataRef(dataRefName, m_stringRefs, CreateDataRefString, XPDataTypes.Data) ?? throw InvalidDataRefException(dataRefName);

        public unsafe bool IntDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_intRefs, CreateDataRefInt, XPDataTypes.Int) != null;

        public unsafe bool IntArrayDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_intArrayRefs, CreateDataRefIntArray, XPDataTypes.IntArray) != null;

        public unsafe bool BoolDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_boolRefs, CreateDataRefBool, XPDataTypes.Int) != null;

        public unsafe bool BoolArrayDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_boolArrayRefs, CreateDataRefBoolArray, XPDataTypes.IntArray) != null;

        public unsafe bool FloatDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_floatRefs, CreateDataRefFloat, XPDataTypes.Float) != null;

        public unsafe bool FloatArrayDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_floatArrayRefs, CreateDataRefFloatArray, XPDataTypes.FloatArray) != null;

        public unsafe bool DoubleDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_doubleRefs, CreateDataRefDouble, XPDataTypes.Double) != null;

        public unsafe bool ByteArrayDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_byteArrayRefs, CreateDataRefByteArray, XPDataTypes.Data) != null;

        public unsafe bool StringDataExists(string dataRefName) =>
            GetDataRef(dataRefName, m_stringRefs, CreateDataRefString, XPDataTypes.Data) != null;

        private unsafe IXPDataRef<T> GetDataRef<T>(
            string dataRefName,
            IDictionary<string, IXPDataRef<T>> cache, DataRefFactory<T> factory,
            XPDataTypes expectedType)
        {
            if (!cache.TryGetValue(dataRefName, out var dr))
            {
                void* dataref = PluginBridge.ApiFunctions.XPLMFindDataRef(dataRefName);
                if (dataref == null)
                    return null;

                var actualTypes = PluginBridge.ApiFunctions.XPLMGetDataRefTypes(dataref);
                if ((actualTypes & expectedType) == 0)
                {
                    PluginBridge.Log.Log($"Warning: DataRef ({dataRefName}) was found but is not of the indicated type ({expectedType}).  Will tell caller it was not found.");
                    return null;
                }

                dr = factory(dataRefName, dataref);
                cache[dataRefName] = dr;
            }

            return dr;
        }

        private unsafe IXPDataRef<int> CreateDataRefInt(string dataRefName, void* dataref) => new XPDataRefInt(dataRefName, dataref);
        private unsafe IXPDataRef<int[]> CreateDataRefIntArray(string dataRefName, void* dataref) => new XPDataRefIntArray(dataRefName, dataref);
        private unsafe IXPDataRef<bool> CreateDataRefBool(string dataRefName, void* dataref) => new XPDataRefBool(dataRefName, dataref);
        private unsafe IXPDataRef<bool[]> CreateDataRefBoolArray(string dataRefName, void* dataref) => new XPDataRefBoolArray(dataRefName, dataref);
        private unsafe IXPDataRef<float> CreateDataRefFloat(string dataRefName, void* dataref) => new XPDataRefFloat(dataRefName, dataref);
        private unsafe IXPDataRef<float[]> CreateDataRefFloatArray(string dataRefName, void* dataref) => new XPDataRefFloatArray(dataRefName, dataref);
        private unsafe IXPDataRef<double> CreateDataRefDouble(string dataRefName, void* dataref) => new XPDataRefDouble(dataRefName, dataref);
        private unsafe IXPDataRef<byte[]> CreateDataRefByteArray(string dataRefName, void* dataref) => new XPDataRefByteArray(dataRefName, dataref);
        private unsafe IXPDataRef<string> CreateDataRefString(string dataRefName, void* dataref) => new XPDataRefString(dataRefName, dataref);

        private InvalidOperationException InvalidDataRefException(string dataRefName)
            => new InvalidOperationException($"The current X-Plane instance does not respond to the dataref ({dataRefName}).");
    }
}
