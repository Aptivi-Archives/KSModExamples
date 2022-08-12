/*
 * Copyright (c) EoflaOE and its companies. All rights reserved.
 * 
 * Name: BSynth.cs
 * Description: Command entry point for "bsynth"
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
using KS.Misc.Writers.DebugWriters;
using KS.Shell.ShellBase.Commands;

namespace BeepSynth
{
    internal class BSynth : CommandExecutor, ICommand
    {
        public override void Execute(string StringArgs, string[] ListArgs, string[] ListArgsOnly, string[] ListSwitchesOnly)
        {
            if (ListArgsOnly.Length >= 1)
                DebugWriter.Wdbg(DebugLevel.I, "Success: " + BeepSynth.TryParseSynth(ListArgsOnly[0]));
            else
                TextWriterColor.Write("Provide a synth file.", true, ColorTools.ColTypes.Neutral);
        }
    }
}
