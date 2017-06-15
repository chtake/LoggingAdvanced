# LoggingAdvanced
[![NuGet](http://img.shields.io/nuget/v/Bodrocode.LoggingAdvanced.Console.svg)](https://www.nuget.org/packages/Bodrocode.LoggingAdvanced.Console/)
[![Build status](https://ci.appveyor.com/api/projects/status/github/ilya-chumakov/LoggingAdvanced?branch=develop&svg=true&retina=true&passingText=develop%20-%20OK&failingText=develop%20-%20FAIL)](https://ci.appveyor.com/project/chumakov-ilya/LoggingAdvanced)


Advanced .NET Core console logger. I forked Microsoft code, improved it and packages as NuGet package.

With [Microsoft.Extensions.Logging.Console](https://github.com/aspnet/Logging):

    info: Microsoft.AspNetCore.Hosting.Internal.WebHost[1]
          Request starting HTTP/1.1 GET http://localhost:6002/hc      
    
With LoggingAdvanced:

    [2017.06.15 23:46:44] info: WebHost[1]      Request starting HTTP/1.1 GET http://localhost:6002/hc

Usage is simple:

    loggerFactory.AddConsoleAdvanced();
    
Of course you could customize it:

    loggerFactory.AddConsoleAdvanced(new ConsoleLoggerSettings()
    {
        IncludeLineBreak = false,
        IncludeTimestamp = true,
        IncludeZeroEventId = false,
        IncludeLogNamespace = false
    });
    
And keep the config in `appsettings.json`:

    loggerFactory.AddConsoleAdvanced(Configuration.GetSection("Logging"));
    
    {
        "Logging": {
            "IncludeLineBreak": true,
            "IncludeTimestamp": true,
            "IncludeZeroEventId": true,
            "IncludeLogNamespace": true
            "TimestampPolicy": {
                "TimeZone": "Ulaanbaatar Standard Time",
                "Format": "MM/dd/yyyy HH:mm:ss.fff"
            }
        }
    }