/*
    A security toolkit for windows    

    Copyright(C) 2016-2017 Guido Lucassen

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.If not, see<http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src.libs.windowslock
{
    class WindowsLock
    {

        private static WindowsLock l;

        private WindowsLock(){}

        /**
         * <summary>locks a Windows file by TrustedInstaller (as intended)</summary>
         * 
         * */
        public void Lock(string file)
        {
            if(file.ToLower().StartsWith(@"c:\windows"))
            {
                //exec("icacls " + file + " /remove d: Administrators:F");
                //exec("icacls " + file + " /grant g: Administrators:RX");

                exec("icacls " + file + " /remove Administrators");
                exec("icacls " + file + " /grant Administrators:RX");
                exec("icacls "+file+" /setowner \"NT SERVICE\\TrustedInstaller\"");
            } else
            {
                throw new Exception("cannot lock non windows files!");
            }
        }

        /**
         * <summary>unlocks a file for the group Administrators (as unintended)</summary>
         * */
        public void Unlock(string file)
        {
            if (file.ToLower().StartsWith(@"c:\windows"))
            {
                //first take ownership.
                exec("takeown /F "+file+" /A");
                //grant administrator group full access.
                exec("icacls "+file+" /grant Administrators:(F)");
            }
            else
            {
                throw new Exception("cannot unlock non windows files!");
            }
        }

        private void exec(string command)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/c " + command;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Dispose();
        }

        public static WindowsLock GetWindowsFileLock()
        {
            if(l == null)
            {
                l = new WindowsLock();
            }
            return l;
        }

    }
}
