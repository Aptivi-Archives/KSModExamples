/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: EventHandler2.cs
 * Description: Entry point for the EventHandler2 mod
 * KS Version: 0.0.20
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/30/2021 | Initial release
 */

using KS.ConsoleBase;
using KS.Modifications;
using KS.Shell.ShellBase;
using KS.Misc.Writers.ConsoleWriters;
using System.Collections.Generic;

namespace EventHandler2
{
    public class EventHandler2 : IScript
    {
        public Dictionary<string, CommandInfo> Commands { get; set; }
        public string Name { get; set; }
        public string ModPart { get; set; }
        public string Version { get; set; }

        public void InitEvents(string ev)
        {
            if (ev == "KernelStarted")
            {
                TextWriterColor.Write("Kernel started!", true, ColorTools.ColTypes.Neutral);
            }
        }

        public void InitEvents(string ev, params object[] Args)
        {
        }

        public void PerformCmd(CommandInfo Command, string Args = "")
        {
        }

        public void StartMod()
        {
            Name = "EventHandler2";
            ModPart = "Main";
            Version = "1.0.0";
        }

        public void StopMod()
        {
        }
    }
}
