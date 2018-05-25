
using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace XPNet
{
    public interface ILog : IDisposable
    {
        void Log(string str);

        void Log(Exception exc);
    }

    public class NullLog : ILog
    {
        public void Log(string str)
        {
            // Ignore.
        }

        public void Log(Exception exc)
        {
            // Ignore.
        }

        public void Dispose()
        {
            // Nothing to do.
        }
    }

    public class StreamLog : ILog
    {
        private readonly bool m_ownsStream;
        private readonly Stream m_stream;
        private readonly TextWriter m_writer;

        internal StreamLog(string path)
            : this(new FileStream(path, FileMode.Append, FileAccess.Write), ownsStream: true)
        { }

        internal StreamLog(Stream stream, bool ownsStream)
        {
            m_ownsStream = ownsStream;
            m_stream = stream;
            m_writer = new StreamWriter(m_stream, new UTF8Encoding(false), bufferSize: 4096, leaveOpen: true);

            m_writer.WriteLine("**********");
            m_writer.WriteLine($"[{DateTime.Now:G}] Logging Started");
            m_writer.Flush();
        }

        public void Dispose()
        {
            if (m_ownsStream)
                m_stream.Dispose();

            m_writer.Flush();
            m_writer.Dispose();
        }

        public void Log(string str)
        {
            m_writer.WriteLine($"[{DateString()}] {str}");
            m_writer.Flush();
        }

        public void Log(Exception exc)
        {
            m_writer.WriteLine("----------");
            m_writer.WriteLine($"[{DateString()}] Exception:");
            m_writer.WriteLine($"{ exc.GetType().Name}: {exc.Message}");
            m_writer.WriteLine("Stack: ");
            m_writer.WriteLine(exc.StackTrace);

            while (exc.InnerException != null)
            {
                exc = exc.InnerException;

                m_writer.WriteLine("");
                m_writer.WriteLine("Inner Exception: ");

                m_writer.WriteLine($"{exc.GetType().Name}: {exc.Message}");
                m_writer.WriteLine("Stack: ");
                m_writer.WriteLine(exc.StackTrace);
            }

            m_writer.WriteLine("----------");
            m_writer.Flush();
        }

        private string DateString()
        {
            return $"{DateTime.Now:hh:mm:ss t}";
        }
    }

    public class FileHandleLog : StreamLog
    {
        internal FileHandleLog(SafeFileHandle hFile)
            : base(new FileStream(hFile, FileAccess.Write), ownsStream: false)
        { }
    }
}
