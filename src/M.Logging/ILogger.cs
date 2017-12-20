namespace M.Logging
{
    public interface ILogger
    {
        void Trace(object message);
        void Trace(string message, params object[] args);
        void Debug(object message);
        void Debug(string message, params object[] args);
        void Info(object message);
        void Info(string message, params object[] args);
        void Warning(object message);
        void Warning(string message, params object[] args);
        void Error(object message);
        void Error(string message, params object[] args);
        void Fatal(object message);
        void Fatal(string message, params object[] args);
    }
}