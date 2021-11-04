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

using KS;
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
            if (Command.Command == "sayhello")
            {
                TextWriterColor.W("Hello World! From the \"sayhello\" command!", true, ColorTools.ColTypes.Neutral);
            } else if (Command.Command == "goodbye")
            {
                TextWriterColor.W("Goodbye World! From the \"goodbye\" command!", true, ColorTools.ColTypes.Neutral);
            }
        }

        public void StartMod()
        {
            Name = "Hello World";
            ModPart = "Multiple commands";
            Version = "1.0.0";
            Commands = new Dictionary<string, CommandInfo> { { "sayhello", new CommandInfo("sayhello", ShellCommandType.Shell, "Say Hello", new[] { "" }, false, 0, null) },
                                                             { "goodbye", new CommandInfo("goodbye", ShellCommandType.Shell, "Say Goodbye", new[] { "" }, false, 0, null) } };

            TextWriterColor.W("Hello World!", true, ColorTools.ColTypes.Neutral);
        }

        public void StopMod()
        {
            TextWriterColor.W("Goodbye World.", true, ColorTools.ColTypes.Neutral);
        }
    }
}
