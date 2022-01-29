/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: HelloWorld1.cs
 * Description: Entry point for the HelloWorld1 mod
 * KS Version: 0.0.20
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/12/2021 | Initial release
 */

using KS;
using KS.ConsoleBase;
using KS.Modifications;
using KS.Shell.ShellBase;
using System.Collections.Generic;

namespace HelloWorld1
{
    class HelloWorld1 : IScript
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
            ModPart = "Main";
            Version = "1.0.0";

            TextWriterColor.Write("Hello World!", true, ColorTools.ColTypes.Neutral);
        }

        public void StopMod()
        {
            TextWriterColor.Write("Goodbye World.", true, ColorTools.ColTypes.Neutral);
        }
    }
}
