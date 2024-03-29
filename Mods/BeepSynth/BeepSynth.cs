﻿/*
 * Copyright (c) Aptivi. All rights reserved.
 * 
 * Name: BeepSynth.cs
 * Description: Entry point for the BeepSynth mod
 * KS Version: 0.0.22
 * 
 * History:
 * 
 * | Author   | Date      | Description
 * +----------+-----------+--------------
 * | Aptivi   | 7/3/2021  | Initial release
 * | Aptivi   | 6/13/2022 | Used CommandExecutor instead of interface
 */

using Extensification.StringExts;
using KS.Files;
using KS.Misc.Writers.DebugWriters;
using KS.Modifications;
using System;
using System.Collections.Generic;
using System.IO;
using KS.Misc.Writers.ConsoleWriters;
using KS.Shell.ShellBase.Commands;
using KS.Shell.ShellBase.Shells;
using KS.ConsoleBase.Colors;

namespace BeepSynth
{
    public class BeepSynth : IScript
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
            Name = "BeepSynth";
            ModPart = "Main";
            Version = "0.0.15.8";
            Commands = new Dictionary<string, CommandInfo> { { "bsynth", new CommandInfo("bsynth", ShellType.Shell, "Loads the synth file and plays it.", new CommandArgumentInfo(new[] { "<file>" }, true, 1), new BSynth()) } };
        }

        public void StopMod()
        {
        }

        /// <summary>
        /// Tries to parse the synth file and play it back using the console PC speaker
        /// </summary>
        /// <param name="file">A file name in current shell path</param>
        /// <returns>True if successful, False if unsuccessful.</returns>
        public static bool TryParseSynth(string file)
        {
            try
            {
                file = Filesystem.NeutralizePath(file);
                DebugWriter.Wdbg(DebugLevel.I, "Probing {0}...", file);
                if (File.Exists(file))
                {
                    // Open the stream
                    StreamReader FStream = new StreamReader(file);
                    DebugWriter.Wdbg(DebugLevel.I, "Opened StreamReader(file) with the length of {0}", FStream.BaseStream.Length);

                    // Read a line and parse it
                    string FStreamLine = FStream.ReadLine();
                    if (FStreamLine == "KS-BSynth")
                    {
                        //Comments are ignored in the file. Comment format: - <message>
                        DebugWriter.Wdbg(DebugLevel.I, "File is scripted");
                        while (!FStream.EndOfStream)
                        {
                            FStreamLine = FStream.ReadLine();
                            DebugWriter.Wdbg(DebugLevel.I, "Line: {0}", FStreamLine);
                            if (!FStreamLine.StartsWith("-") && !(string.IsNullOrEmpty(FStreamLine)))
                            {
                                try
                                {
                                    DebugWriter.Wdbg(DebugLevel.I, "Not a comment. Getting frequency and time...");
                                    int freq = Convert.ToInt32(FStreamLine.Remove(FStreamLine.IndexOf(",")));
                                    int ms = Convert.ToInt32(FStreamLine.Substring(FStreamLine.IndexOf(",") + 1));
                                    DebugWriter.Wdbg(DebugLevel.I, "Got frequency {0} Hz and time {1} ms", freq, ms);
                                    Console.Beep(freq, ms);
                                }
                                catch (Exception ex)
                                {
                                    DebugWriter.Wdbg(DebugLevel.E, "Not a comment and not a synth line. ({0}) {1}", FStreamLine, ex.Message);
                                    TextWriterColor.Write("Failed to probe a synth line: {0}", true, ColorTools.ColTypes.Error, ex.Message);
                                }
                            }
                        }
                        return true;
                    }
                    else
                    {
                        DebugWriter.Wdbg(DebugLevel.E, "File is not scripted");
                        TextWriterColor.Write("The file isn't a scripted synth file.", true, ColorTools.ColTypes.Error);
                    }
                }
                else
                {
                    DebugWriter.Wdbg(DebugLevel.E, "File doesn't exist");
                    TextWriterColor.Write("Scripted file {0} does not exist.".FormatString(file), true, ColorTools.ColTypes.Error);
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
