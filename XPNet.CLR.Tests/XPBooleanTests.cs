
using System;
using System.Runtime.InteropServices;
using Xunit;

namespace XPNet.CLR.Tests
{
    public class XPBooleanTests
    {
        [Fact]
        public unsafe void XPBooleanHasSameFootprintAsInt32()
        {
            var theXPBoolean = XPBoolean.True;
            var theInt32 = 0;

            // Verifying that the compiler and runtime engine see them as the same.
            Assert.Equal(sizeof(XPBoolean), sizeof(Int32));
            Assert.Equal(Marshal.SizeOf(theXPBoolean), Marshal.SizeOf(theInt32));

            var theXPBooleanArray = new XPBoolean[20];
            fixed (XPBoolean* pb = theXPBooleanArray)
            {
                int* pi = (int*)pb;
                pi[10] = 1;
            }

            // Verifying that writing to a pointer-array of one type as if it
            // were the other type yields the expected results.
            Assert.False(theXPBooleanArray[9].Value);
            Assert.True(theXPBooleanArray[10].Value);
            Assert.False(theXPBooleanArray[8].Value);
        }
    }
}
