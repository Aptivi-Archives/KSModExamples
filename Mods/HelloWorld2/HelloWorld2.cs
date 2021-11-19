/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: HelloWorld2.cs
 * Description: Entry point for the HelloWorld2 mod
 * KS Version: 0.0.20
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/12/2021 | Initial release
 */

using KS;
using System.Collections.Generic;

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
            if (Command.Command == "hello")
            {
                TextWriterColor.Write("Hello World! From the \"hello\" command!", true, ColorTools.ColTypes.Neutral);
            }
        }

        public void StartMod()
        {
            Name = "Hello World";
            ModPart = "Command";
            Version = "1.0.0";
            Commands = new Dictionary<string, CommandInfo> { { "hello", new CommandInfo("hello", ShellCommandType.Shell, "Say Hello", new[] { "" }, false, 0, null) } };

            TextWriterColor.Write("Hello World!", true, ColorTools.ColTypes.Neutral);
        }

        public void StopMod()
        {
            TextWriterColor.Write("Goodbye World.", true, ColorTools.ColTypes.Neutral);
        }
    }
}
