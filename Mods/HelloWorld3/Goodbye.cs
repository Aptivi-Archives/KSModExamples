/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: SayHello.cs
 * Description: Command entry point for "sayhello"
 * KS Version: 0.0.22
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | EoflaOE  | 6/13/2022 | Initial release
 */

using KS.ConsoleBase.Colors;
using KS.Misc.Writers.ConsoleWriters;
using KS.Shell.ShellBase.Commands;

namespace HelloWorld3
{
    internal class Goodbye : CommandExecutor, ICommand
    {
        public override void Execute(string StringArgs, string[] ListArgs, string[] ListArgsOnly, string[] ListSwitchesOnly)
        {
            TextWriterColor.Write("Goodbye World! From the \"goodbye\" command!", true, ColorTools.ColTypes.Neutral);
        }
    }
}
