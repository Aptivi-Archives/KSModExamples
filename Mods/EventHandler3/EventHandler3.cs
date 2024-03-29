﻿/*
 * Copyright (c) Aptivi. All rights reserved.
 * 
 * Name: EventHandler3.cs
 * Description: Entry point for the EventHandler3 mod
 * KS Version: 0.0.20
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | Aptivi   | 7/2/2021  | Initial release
 */

using KS.Modifications;
using KS.Misc.Writers.ConsoleWriters;
using System.Collections.Generic;
using KS.Shell.ShellBase.Commands;
using KS.ConsoleBase.Colors;

namespace EventHandler3
{
    public class EventHandler3 : IScript
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
            if (ev == "PostLogin")
            {
                TextWriterColor.Write("Logged in as: {0}", true, ColorTools.ColTypes.Neutral, Args[0]);
            }
        }

        public void PerformCmd(CommandInfo Command, string Args = "")
        {
        }

        public void StartMod()
        {
            Name = "EventHandler3";
            ModPart = "Main";
            Version = "1.0.0";
        }

        public void StopMod()
        {
        }
    }
}
