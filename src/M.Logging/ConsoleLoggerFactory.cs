using System;
using System.Collections.Concurrent;

namespace M.Logging
{
    public class ConsoleLoggerFactory : ILoggerFactory
    {
        private readonly ConcurrentDictionary<Type, ILogger> _loggers = new ConcurrentDictionary<Type, ILogger>();

        public ILogger CreateFor(Type type)
        {
            return _loggers.GetOrAdd(type, t => new ConsoleLogger(t));
        }
    }
}
