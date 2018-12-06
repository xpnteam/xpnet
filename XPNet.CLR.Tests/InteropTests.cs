using System;
using System.Text;
using Xunit;

namespace XPNet.CLR.Tests
{
    public class InteropTests
    {
        [Fact]
        public unsafe void CopyCStringCopies()
        {
            string src = "Hello";
            var len = src.Length + 1;
            byte* dst = stackalloc byte[len];

            Interop.CopyCString(dst, len, src);

            var expected = new byte[len]; // CLR initializes everything to zero so our last byte will null-terminate the 'expected' string automatically.
            Encoding.ASCII.GetBytes(src, expected);

            for (int i = 0; i < len; ++i)
                Assert.Equal(dst[i], expected[i]);
        }

        [Fact]
        public unsafe void CopyCStringTruncates()
        {
            string src = "Hello";
            var len = src.Length - 1; // Allocate two-too-few bytes (will miss the 'o' and the null terminator).
            byte* dst = stackalloc byte[len];

            Interop.CopyCString(dst, len, src);

            var expected = new byte[len];
            Encoding.ASCII.GetBytes(src.AsSpan(0, len), expected);
            expected[len - 1] = 0; // Must null-terminate manually b/c of the truncation.

            for (int i = 0; i < len; ++i)
                Assert.Equal(dst[i], expected[i]);
        }
    }
}
