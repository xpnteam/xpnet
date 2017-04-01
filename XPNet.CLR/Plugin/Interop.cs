
using System;
using System.Text;

namespace XPNet
{
    /// <summary>
    /// Contains utility methods for interoperating with non-CLR code (like
    /// other X-Plane plugins or with X-Plane APIs that aren't directly supported
    /// by XPNet yet).
    /// </summary>
    public static unsafe class Interop
    {
        /// <summary>
        /// Copies the given CLR string into the given byte buffer as a
        /// a null-terminated ASCII C-string.
        /// </summary>
        public static void CopyCString(byte* pDst, int destLength, string src)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(src);
            int nBytesToCopy = Math.Min(bytes.Length, destLength - 1);
            fixed (byte* pSrc0 = &bytes[0])
            {
                byte* pSrc = pSrc0;
                for (int i = 0; i < nBytesToCopy; ++i, ++pDst, ++pSrc)
                    *pDst = *pSrc;

                *pDst = 0; // Null terminate
            }
        }
    }
}
