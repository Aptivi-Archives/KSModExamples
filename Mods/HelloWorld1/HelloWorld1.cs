/*
 * Copyright (c) Aptivi. All rights reserved.
 * 
 * Name: HelloWorld1.cs
 * Description: Entry point for the HelloWorld1 mod
 * KS Version: 0.0.20
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | Aptivi   | 6/12/2021 | Initial release
 */

using KS.Modifications;
using KS.Misc.Writers.ConsoleWriters;
using System.Collections.Generic;
using KS.Shell.ShellBase.Commands;
using KS.ConsoleBase.Colors;

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
