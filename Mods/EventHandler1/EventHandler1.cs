/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: EventHandler1.cs
 * Description: Entry point for the EventHandler1 mod
 * KS Version: 0.0.20
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/30/2021 | Initial release
 */

using KS.Modifications;
using KS.Misc.Writers.ConsoleWriters;
using System.Collections.Generic;
using KS.Shell.ShellBase.Commands;
using KS.ConsoleBase.Colors;

namespace EventHandler1
{
    public class EventHandler1 : IScript
    {
        public Dictionary<string, CommandInfo> Commands { get; set; }
        public string Name { get; set; }
        public string ModPart { get; set; }
        public string Version { get; set; }

        public void InitEvents(string ev)
        {
            TextWriterColor.Write(ev, true, ColorTools.ColTypes.Neutral);
        }

        public void InitEvents(string ev, params object[] Args)
        {
        }

        public void PerformCmd(CommandInfo Command, string Args = "")
        {
        }

        public void StartMod()
        {
            Name = "EventHandler1";
            ModPart = "Main";
            Version = "1.0.0";
        }

        public void StopMod()
        {
        }
    }
}
