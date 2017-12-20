# M.Logging
---  
[![NuGet](https://img.shields.io/nuget/v/M.Logging.svg)](https://www.nuget.org/packages/M.Logging)  

A logging abstraction.  

**ILogger** - abstracts logging different log levels  
**ILoggerFactory** - creates a logger per type  
**Log** - a "static gateway" for ILogger instances  
As a cross-cutting concern logging should be available everywhere. This leads to injecting/creating a logger in most of the classes adding "noise".  
The downside of using "static gateway" is ending up with a hidden dependency, which in this particular case is tolerable compromise.     

**ConsoleLogger** - a default implementation for simple applications or to avoid additional setups in unit tests.  
  
*Example:*  

	// at the beginning of the program
	Log.Initialize(new ConsoleLoggerFactory());
	...
	// then start logging using approriate log level: Trace, Debug, Info, etc.
	...
	// in static class/method
	Log.For<TheStaticClass>().Info("...");
	// or
	Log.For(typeof(TheStaticClass)).Info("...");
	...
	// in an instance
	Log.For(this).Info("...");
  

# M.Logging.NLog  
---  
[![NuGet](https://img.shields.io/nuget/v/M.Logging.NLog.svg)](https://www.nuget.org/packages/M.Logging.NLog)  

A M.Logging abstraction implementation utilizing [NLog](http://nlog-project.org/) for logging. 

*Example:*  

	// configure NLog in app.config or via code;
	// at the beginning of the program
	Log.Initialize(new NLogLoggerFactory());
	...
	// then start logging using approriate log level: Trace, Debug, Info, etc.
	...
	// in static class/method
	Log.For<TheStaticClass>().Info("...");
	// or
	Log.For(typeof(TheStaticClass)).Info("...");
	...
	// in an instance
	Log.For(this).Info("...");
