/*
 * Copyright (c) Aptivi. All rights reserved.
 * 
 * Name: HelloWorld2.cs
 * Description: Entry point for the HelloWorld2 mod
 * KS Version: 0.0.22
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | Aptivi   | 6/12/2021 | Initial release
 * | Aptivi   | 6/13/2022 | Used CommandExecutor instead of interface
 */

using KS.Modifications;
using KS.Misc.Writers.ConsoleWriters;
using System.Collections.Generic;
using KS.Shell.ShellBase.Commands;
using KS.Shell.ShellBase.Shells;
using KS.ConsoleBase.Colors;

namespace HelloWorld2
{
    public class HelloWorld2 : IScript
    {
        public Dictionary<string, CommandInfo> Commands { get; set; }
        public string Name { get; set; }
        public string ModPart { get; set; }
        public string Version { get; set; }

        public void InitEvents(string ev)
        {
        }

        public void InitEvents(string ev, params object[] Args)
        {
        }

        public void PerformCmd(CommandInfo Command, string Args = "")
        {
        }

        public void StartMod()
        {
            Name = "Hello World";
            ModPart = "Command";
            Version = "1.0.0";
            Commands = new Dictionary<string, CommandInfo> { { "hello", new CommandInfo("hello", ShellType.Shell, "Say Hello", new CommandArgumentInfo(new[] { "" }, false, 0), new Hello()) } };

            TextWriterColor.Write("Hello World!", true, ColorTools.ColTypes.Neutral);
        }

        public void StopMod()
        {
            TextWriterColor.Write("Goodbye World.", true, ColorTools.ColTypes.Neutral);
        }
    }
}
