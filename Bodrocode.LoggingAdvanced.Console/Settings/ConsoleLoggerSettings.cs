﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace Bodrocode.LoggingAdvanced.Console
{
    public class ConsoleLoggerSettings : IConsoleLoggerSettings
    {
        static ConsoleLoggerSettings()
        {
            Default = new ConsoleLoggerSettings()
            {
                IncludeScopes = false,
            };
        }

        public static ConsoleLoggerSettings Default { get; }
        
        public bool IncludeScopes { get; set; }

        public IChangeToken ChangeToken { get; set; }

        public IDictionary<string, LogLevel> Switches { get; set; } = new Dictionary<string, LogLevel>();

        public IConsoleLoggerSettings Reload()
        {
            return this;
        }

        public bool TryGetSwitch(string name, out LogLevel level)
        {
            return Switches.TryGetValue(name, out level);
        }
    }
}