
using System;
using System.Text;

namespace XPNet
{
    // ENHANCE: If we ever get that "where T : blittable" constraint, we
    // can the *Array classes here for int, bool, float and byte into a single
    // generic implementation.

    [Flags]
    internal enum XPDataTypes : int // Maps to XPLMDataTypeID
    {
        Unknown = 0,
        Int = 1,
        Float = 2,
        Double = 4,
        FloatArray = 8,
        IntArray = 16,
        Data = 32
    }

    public interface IXPDataRef
    {
        string Name { get; }
    }

    public interface IXPDataRef<T> : IXPDataRef
    {
        T Value { get; set; }
    }

    internal abstract class XPDataRefBase<T> : IXPDataRef<T>
    {
        internal unsafe XPDataRefBase(string name, void* dataref)
        {
            Name = name;
            DataRef = dataref;
        }

        public string Name
        {
            get;
        }

        public abstract T Value
        {
            get;
            set;
        }

        internal unsafe void* DataRef;
    }

    internal sealed class XPDataRefInt : XPDataRefBase<int>
    {
        internal unsafe XPDataRefInt(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override int Value
        {
            get => PluginBridge.ApiFunctions.XPLMGetDatai(DataRef);
            set => PluginBridge.ApiFunctions.XPLMSetDatai(DataRef, value);
        }
    }

    internal sealed class XPDataRefBool : XPDataRefBase<bool>
    {
        internal unsafe XPDataRefBool(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override bool Value
        {
            get => PluginBridge.ApiFunctions.XPLMGetDatai(DataRef) == 0 ? false : true;
            set => PluginBridge.ApiFunctions.XPLMSetDatai(DataRef, value ? 1 : 0);
        }
    }

    internal sealed class XPDataRefFloat : XPDataRefBase<float>
    {
        internal unsafe XPDataRefFloat(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override float Value
        {
            get => PluginBridge.ApiFunctions.XPLMGetDataf(DataRef);
            set => PluginBridge.ApiFunctions.XPLMSetDataf(DataRef, value);
        }
    }

    internal sealed class XPDataRefDouble : XPDataRefBase<double>
    {
        internal unsafe XPDataRefDouble(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override double Value
        {
            get => PluginBridge.ApiFunctions.XPLMGetDatad(DataRef);
            set => PluginBridge.ApiFunctions.XPLMSetDatad(DataRef, value);
        }
    }

    internal sealed class XPDataRefIntArray : XPDataRefBase<int[]>
    {
        private int[] m_buffer;

        internal unsafe XPDataRefIntArray(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override int[] Value
        {
            get
            {
                int nValues = PluginBridge.ApiFunctions.XPLMGetDatavi(DataRef, null, 0, 0);

                EnsureBuffer(nValues);

                if (nValues > 0)
                {
                    fixed (int* p = &m_buffer[0])
                        PluginBridge.ApiFunctions.XPLMGetDatavi(DataRef, p, 0, nValues);
                }

                return m_buffer;
            }

            set
            {
                if (value.Length > 0)
                {
                    fixed (int* p = &value[0])
                        PluginBridge.ApiFunctions.XPLMSetDatavi(DataRef, p, 0, value.Length);
                }
                else
                {
                    PluginBridge.ApiFunctions.XPLMSetDatavi(DataRef, null, 0, 0);
                }
            }
        }

        private void EnsureBuffer(int nValues)
        {
            // Because we directly expose our internal buffer from Value, we
            // must size our internal buffer here to /exactly/ match the
            // required size, rather than just being "big enough".
            //
            // 1. I don't know that X-Plane ever changes the size of a returned
            //    dataref.  If it does, it's probably only on config changes,
            //    not constantly on every frame.  So we expect to actually have
            //    to realloc here rarely or never, after the array gets initially
            //    created.
            // 2. We could use ArraySegment to handle this too, but that's
            //    less straightforward for the users to use, and see #1.

            if (m_buffer == null || m_buffer.Length != nValues)
                m_buffer = new int[nValues];
        }
    }

    internal sealed class XPDataRefBoolArray : XPDataRefBase<bool[]>
    {
        private bool[] m_buffer;

        internal unsafe XPDataRefBoolArray(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override bool[] Value
        {
            get
            {
                int nValues = PluginBridge.ApiFunctions.XPLMGetDatavi(DataRef, null, 0, 0);

                EnsureBuffer(nValues);

                if (nValues > 0)
                {
                    fixed (bool* p = &m_buffer[0])
                        PluginBridge.ApiFunctions.XPLMGetDatavi(DataRef, (int*)p, 0, nValues);
                }

                return m_buffer;
            }

            set
            {
                if (value.Length > 0)
                {
                    fixed (bool* p = &value[0])
                        PluginBridge.ApiFunctions.XPLMSetDatavi(DataRef, (int*)p, 0, value.Length);
                }
                else
                {
                    PluginBridge.ApiFunctions.XPLMSetDatavi(DataRef, null, 0, 0);
                }
            }
        }

        private void EnsureBuffer(int nValues)
        {
            // Because we directly expose our internal buffer from Value, we
            // must size our internal buffer here to /exactly/ match the
            // required size, rather than just being "big enough".
            //
            // 1. I don't know that X-Plane ever changes the size of a returned
            //    dataref.  If it does, it's probably only on config changes,
            //    not constantly on every frame.  So we expect to actually have
            //    to realloc here rarely or never, after the array gets initially
            //    created.
            // 2. We could use ArraySegment to handle this too, but that's
            //    less straightforward for the users to use, and see #1.

            if (m_buffer == null || m_buffer.Length != nValues)
                m_buffer = new bool[nValues];
        }
    }

    internal sealed class XPDataRefFloatArray : XPDataRefBase<float[]>
    {
        private float[] m_buffer;

        internal unsafe XPDataRefFloatArray(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override float[] Value
        {
            get
            {
                int nValues = PluginBridge.ApiFunctions.XPLMGetDatavf(DataRef, null, 0, 0);

                EnsureBuffer(nValues);

                if (nValues > 0)
                {
                    fixed (float* p = &m_buffer[0])
                        PluginBridge.ApiFunctions.XPLMGetDatavf(DataRef, p, 0, nValues);
                }

                return m_buffer;
            }

            set
            {
                if (value.Length > 0)
                {
                    fixed (float* p = &value[0])
                        PluginBridge.ApiFunctions.XPLMSetDatavf(DataRef, p, 0, value.Length);
                }
                else
                {
                    PluginBridge.ApiFunctions.XPLMSetDatavf(DataRef, null, 0, 0);
                }
            }
        }

        private void EnsureBuffer(int nValues)
        {
            // Because we directly expose our internal buffer from Value, we
            // must size our internal buffer here to /exactly/ match the
            // required size, rather than just being "big enough".
            //
            // 1. I don't know that X-Plane ever changes the size of a returned
            //    dataref.  If it does, it's probably only on config changes,
            //    not constantly on every frame.  So we expect to actually have
            //    to realloc here rarely or never, after the array gets initially
            //    created.
            // 2. We could use ArraySegment to handle this too, but that's
            //    less straightforward for the users to use, and see #1.

            if (m_buffer == null || m_buffer.Length != nValues)
                m_buffer = new float[nValues];
        }
    }

    internal sealed class XPDataRefByteArray : XPDataRefBase<byte[]>
    {
        private byte[] m_buffer;

        internal unsafe XPDataRefByteArray(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override byte[] Value
        {
            get
            {
                int nValues = PluginBridge.ApiFunctions.XPLMGetDatab(DataRef, null, 0, 0);

                EnsureBuffer(nValues);

                if (nValues > 0)
                {
                    fixed (byte* p = &m_buffer[0])
                        PluginBridge.ApiFunctions.XPLMGetDatab(DataRef, p, 0, nValues);
                }

                return m_buffer;
            }

            set
            {
                if (value.Length > 0)
                {
                    fixed (byte* p = &value[0])
                        PluginBridge.ApiFunctions.XPLMSetDatab(DataRef, p, 0, value.Length);
                }
                else
                {
                    PluginBridge.ApiFunctions.XPLMSetDatab(DataRef, null, 0, 0);
                }
            }
        }

        private void EnsureBuffer(int nValues)
        {
            // Because we directly expose our internal buffer from Value, we
            // must size our internal buffer here to /exactly/ match the
            // required size, rather than just being "big enough".
            //
            // 1. I don't know that X-Plane ever changes the size of a returned
            //    dataref.  If it does, it's probably only on config changes,
            //    not constantly on every frame.  So we expect to actually have
            //    to realloc here rarely or never, after the array gets initially
            //    created.
            // 2. We could use ArraySegment to handle this too, but that's
            //    less straightforward for the users to use, and see #1.

            if (m_buffer == null || m_buffer.Length != nValues)
                m_buffer = new byte[nValues];
        }
    }

    internal sealed class XPDataRefString : XPDataRefBase<string>
    {
        private byte[] m_buffer;
        private Encoding m_encoding = Encoding.ASCII;

        internal unsafe XPDataRefString(string name, void* dataref)
            : base(name, dataref)
        { }

        public unsafe override string Value
        {
            get
            {
                int nBytes = PluginBridge.ApiFunctions.XPLMGetDatab(DataRef, null, 0, 0);

                EnsureBuffer(nBytes);

                if (nBytes == 0)
                    return string.Empty;

                fixed (byte* pb = &m_buffer[0])
                {
                    PluginBridge.ApiFunctions.XPLMGetDatab(DataRef, pb, 0, nBytes);
                    return m_encoding.GetString(pb, nBytes);
                }
            }

            set
            {
                if (value.Length > 0)
                {
                    int nMaxBytes = m_encoding.GetMaxByteCount(value.Length);
                    EnsureBuffer(nMaxBytes);

                    fixed (char* vc = value)
                    fixed (byte* pb = &m_buffer[0])
                    {
                        int nBytes = m_encoding.GetBytes(vc, value.Length, pb, m_buffer.Length);
                        PluginBridge.ApiFunctions.XPLMSetDatab(DataRef, pb, 0, nBytes);
                    }
                }
                else
                {
                    PluginBridge.ApiFunctions.XPLMSetDatab(DataRef, null, 0, 0);
                }
            }
        }

        private void EnsureBuffer(int nBytes)
        {
            if (m_buffer == null || m_buffer.Length < nBytes)
                m_buffer = new byte[nBytes];
        }
    }
}
