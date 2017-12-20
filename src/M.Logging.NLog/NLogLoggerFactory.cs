using System;
using System.Collections.Concurrent;

namespace M.Logging.NLog
{
    public class NLogLoggerFactory : ILoggerFactory
    {
        private ConcurrentDictionary<Type, ILogger> _loggers = new ConcurrentDictionary<Type, ILogger>();

        public ILogger CreateFor(Type type) => _loggers.GetOrAdd(type, t => new NLogLogger(t));
    }
}
