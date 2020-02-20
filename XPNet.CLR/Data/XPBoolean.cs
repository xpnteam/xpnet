
using System;
using System.Runtime.InteropServices;

namespace XPNet
{
    /// <summary>
    /// Represents a boolean field in the X-Plane API.  Though not a bool
    /// itself, XPBoolean may be used just like a boolean in various contexts.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public readonly struct XPBoolean : IEquatable<XPBoolean>, IEquatable<bool>
    {
        // X-Plane has DataRefs that are logically booleans, but are represented
        // as In32s.  We'd like to represent those in the .NET world as booleans;
        // this struct lets us bridge the gap.  You can make an array of these and
        // efficiently map them to an X-Plane bool (int32) data array without a copy.
        //
        // To work, this structure must have the exact same footprint (size in
        // memory and packing) as an Int32 array.

        private readonly int m_value;

        public XPBoolean(bool value)
        {
            m_value = value ? 1 : 0;
        }

        public bool Value => m_value != 0;

        public static XPBoolean True = new XPBoolean(true);
        public static XPBoolean False = new XPBoolean(false);

        public static implicit operator bool(XPBoolean val)
        {
            return val.Value;
        }

        public static implicit operator XPBoolean(bool val)
        {
            return new XPBoolean(val);
        }

        #region Equality

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj) => (obj is XPBoolean && Equals((XPBoolean)obj)) || (obj is bool && Equals((bool)obj));

        public bool Equals(XPBoolean other) => Value == other.Value;

        public bool Equals(bool other) => Value == other;

        public static bool operator ==(XPBoolean lhs, XPBoolean rhs) => lhs.Equals(rhs);
        public static bool operator !=(XPBoolean lhs, XPBoolean rhs) => lhs.Equals(rhs);

        public static bool operator ==(XPBoolean lhs, bool rhs) => lhs.Equals(rhs);
        public static bool operator !=(XPBoolean lhs, bool rhs) => lhs.Equals(rhs);

        public static bool operator ==(bool lhs, XPBoolean rhs) => rhs.Equals(lhs);
        public static bool operator !=(bool lhs, XPBoolean rhs) => rhs.Equals(lhs);

        #endregion // Equality
    }
}
