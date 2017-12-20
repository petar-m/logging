using System;

namespace M.Logging
{
    public class ConsoleLogger : ILogger
    {
        private string _typeName;

        public ConsoleLogger(Type type)
        {
            _typeName = type.FullName;
        }

        public void Trace(object message) => Write(Level.Trace, message);

        public void Trace(string message, params object[] args) => Write(Level.Trace, message, args);

        public void Debug(object message) => Write(Level.Debug, message);

        public void Debug(string message, params object[] args) => Write(Level.Debug, message, args);

        public void Info(object message) => Write(Level.Info, message);

        public void Info(string message, params object[] args) => Write(Level.Info, message, args);

        public void Warning(object message) => Write(Level.Warning, message);

        public void Warning(string message, params object[] args) => Write(Level.Warning, message, args);

        public void Error(object message) => Write(Level.Error, message);

        public void Error(string message, params object[] args) => Write(Level.Error, message, args);

        public void Fatal(object message) => Write(Level.Fatal, message);

        public void Fatal(string message, params object[] args) => Write(Level.Fatal, message, args);

        private void Write(string level, string message, params object[] args)
        {
            Console.WriteLine("{0} {1} {2} {3}", level, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), _typeName, string.Format(message, args));
        }

        private void Write(string level, object message)
        {
            Console.WriteLine("{0} {1} {2} {3}", level, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), _typeName, message);
        }

        protected static class Level
        {
            public const string Trace = "TRACE";
            public const string Debug = "DEBUG";
            public const string Info = "INFO";
            public const string Warning = "WARNING";
            public const string Error = "ERROR";
            public const string Fatal = "FATAL";
        }
    }
}