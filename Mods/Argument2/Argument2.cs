/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: Argument2.cs
 * Description: Entry point for the Argument2 mod
 * KS Version: 0.0.22
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/30/2021 | Initial release
 * | EoflaOE  | 6/13/2022 | Used CommandExecutor instead of interface
 */

using Extensification.StringExts;
using KS.ConsoleBase;
using KS.Modifications;
using KS.Shell.ShellBase;
using KS.Misc.Writers.ConsoleWriters;
using System.Collections.Generic;

namespace Argument2
{
    public class Argument2 : IScript
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
            Name = "Argument2";
            ModPart = "Main";
            Version = "1.0.0";
            Commands = new Dictionary<string, CommandInfo> { { "say", new CommandInfo("say", ShellType.Shell, "Say a word", new[] { "<word>" }, true, 1, new Say()) } };
        }

        public void StopMod()
        {
        }
    }
}
