﻿using System.Collections.Generic;

namespace Flow.Launcher.Plugin.Shell
{
    public class Settings
    {
        public Shell Shell { get; set; } = Shell.Cmd;
        public bool ReplaceWinR { get; set; } = true;
        public bool LeaveShellOpen { get; set; }
        public bool RunAsAdministrator { get; set; } = true;

        public Dictionary<string, int> Count = new Dictionary<string, int>();

        public void AddCmdHistory(string cmdName)
        {
            if (Count.ContainsKey(cmdName))
            {
                Count[cmdName] += 1;
            }
            else
            {
                Count.Add(cmdName, 1);
            }
        }
    }

    public enum Shell
    {
        Cmd = 0,
        Powershell = 1,
        RunCommand = 2,

    }
}
