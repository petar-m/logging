using System;

namespace M.Logging
{
    public static class Log
    {
        // useful for unit tests to avoid additional setups
        private static ILoggerFactory _factory = new ConsoleLoggerFactory();

        public static void Initialize(ILoggerFactory loggerFactory) => _factory = loggerFactory;

        public static ILogger For(Type type) => _factory.CreateFor(type);

        public static ILogger For<T>() => For(typeof(T));

        public static ILogger For(object source) => For(source.GetType());
    }
}