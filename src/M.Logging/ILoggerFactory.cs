using System;

namespace M.Logging
{
    public interface ILoggerFactory
    {
        ILogger CreateFor(Type type);
    }
}
