/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: HelloWorld3.cs
 * Description: Entry point for the HelloWorld3 mod
 * KS Version: 0.0.20
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/13/2021 | Initial release
 */

using KS.ConsoleBase;
using KS.Modifications;
using KS.Shell.ShellBase;
using KS.Misc.Writers.ConsoleWriters;
using System.Collections.Generic;

namespace HelloWorld3
{
    public class HelloWorld3 : IScript
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
            ModPart = "Multiple commands";
            Version = "1.0.0";
            Commands = new Dictionary<string, CommandInfo> { { "sayhello", new CommandInfo("sayhello", ShellType.Shell, "Say Hello", new[] { "" }, false, 0, new SayHello()) },
                                                             { "goodbye", new CommandInfo("goodbye", ShellType.Shell, "Say Goodbye", new[] { "" }, false, 0, new Goodbye()) } };

            TextWriterColor.Write("Hello World!", true, ColorTools.ColTypes.Neutral);
        }

        public void StopMod()
        {
            TextWriterColor.Write("Goodbye World.", true, ColorTools.ColTypes.Neutral);
        }
    }
}
