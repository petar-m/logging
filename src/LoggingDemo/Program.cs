using System;
using M.Logging;
using M.Logging.NLog;
using M.Utilities.Logging;
using NLog;
using static System.Console;

namespace LoggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("ConsoleLogger =====================");
            GenerateLogs();
            WriteLine();

            WriteLine("NLogLogger =====================");
            Log.Initialize(new NLogLoggerFactory());
            GenerateLogs();
            WriteLine();

            WriteLine("NLogLogger MemoryLogger =====================");
            var target = (NlogMemoryTarget)LogManager.Configuration.FindTargetByName("CustomMemoryLogger");
            foreach (var entry in target.Logs)
            {
                WriteLine(entry);
            }
            WriteLine();

            ReadKey();
        }

        private static void GenerateLogs()
        {
            Log.For<Program>().Trace("Hello Trace");
            Log.For<Program>().Trace("Hello Trace {0} {1}", "with argument now", DateTime.Now);
            try
            {
                throw new Exception("Trace exception");
            }
            catch (Exception exception)
            {
                Log.For<Program>().Trace(exception);
                Log.For<Program>().Trace("Trace Exception caught: {0}", exception);
            }

            Log.For<Program>().Debug("Hello Debug");
            Log.For<Program>().Debug("Hello Debug {0} {1}", "with argument now", DateTime.Now);
            try
            {
                throw new Exception("Debug exception");
            }
            catch (Exception exception)
            {
                Log.For<Program>().Debug(exception);
                Log.For<Program>().Debug("Debug Exception caught: {0}", exception);
            }

            Log.For<Program>().Info("Hello Info");
            Log.For<Program>().Info("Hello Info {0} {1}", "with argument now", DateTime.Now);
            try
            {
                throw new Exception("Info exception");
            }
            catch (Exception exception)
            {
                Log.For<Program>().Info(exception);
                Log.For<Program>().Info("Info Exception caught: {0}", exception);
            }

            Log.For<Program>().Warning("Hello Warning");
            Log.For<Program>().Warning("Hello Warning {0} {1}", "with argument now", DateTime.Now);
            try
            {
                throw new Exception("Warning exception");
            }
            catch (Exception exception)
            {
                Log.For<Program>().Warning(exception);
                Log.For<Program>().Warning("Warning Exception caught: {0}", exception);
            }

            Log.For<Program>().Error("Hello Error");
            Log.For<Program>().Error("Hello Error {0} {1}", "with argument now", DateTime.Now);
            try
            {
                throw new Exception("Error exception");
            }
            catch (Exception exception)
            {
                Log.For<Program>().Error(exception);
                Log.For<Program>().Error("Error Exception caught: {0}", exception);
            }

            Log.For<Program>().Fatal("Hello Fatal");
            Log.For<Program>().Fatal("Hello Fatal {0} {1}", "with argument now", DateTime.Now);
            try
            {
                throw new Exception("Fatal exception");
            }
            catch (Exception exception)
            {
                Log.For<Program>().Fatal(exception);
                Log.For<Program>().Fatal("Fatal Exception caught: {0}", exception);
            }
        }
    }
}
