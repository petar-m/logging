using System;
using NLog;

namespace M.Logging.NLog
{
    public class NLogLogger : ILogger
    {
        private readonly Logger _logger;

        public NLogLogger(Type type)
        {
            _logger = LogManager.GetLogger(type.FullName);
        }

        public void Trace(object message) => _logger.Trace(message);

        public void Trace(string message, params object[] args) => _logger.Trace(message, args);

        public void Debug(object message) => _logger.Debug(message);

        public void Debug(string message, params object[] args) => _logger.Debug(message, args);

        public void Info(object message) => _logger.Info(message);

        public void Info(string message, params object[] args) => _logger.Info(message, args);

        public void Warning(object message) => _logger.Warn(message);

        public void Warning(string message, params object[] args) => _logger.Warn(message, args);

        public void Error(object message) => _logger.Error(message);

        public void Error(string message, params object[] args) => _logger.Error(message, args);

        public void Fatal(object message) => _logger.Fatal(message);

        public void Fatal(string message, params object[] args) => _logger.Fatal(message, args);
    }
}
