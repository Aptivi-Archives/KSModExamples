/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: Say.cs
 * Description: Command entry point for "say"
 * KS Version: 0.0.22
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/13/2022 | Initial release
 */

using KS.ConsoleBase;
using KS.Misc.Writers.ConsoleWriters;
using KS.Shell.ShellBase;

namespace Argument2
{
    internal class Say : CommandExecutor, ICommand
    {
        public override void Execute(string StringArgs, string[] ListArgs, string[] ListArgsOnly, string[] ListSwitchesOnly)
        {
            if (ListArgsOnly.Length >= 1)
                TextWriterColor.Write(ListArgsOnly[0], true, ColorTools.ColTypes.Neutral);
            else
                TextWriterColor.Write("Say something.", true, ColorTools.ColTypes.Neutral);
        }
    }
}
