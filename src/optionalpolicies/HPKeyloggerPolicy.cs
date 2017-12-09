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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.controls;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class HPKeyloggerPolicy : OptionalPolicy
    {
        public override string GetName()
        {
            return GetOptionalPolicyType().GetName();
        }

        public override OptionalPolicyType GetOptionalPolicyType()
        {
            return OptionalPolicyType.HP_KEYLOGGER_POLICY;
        }

        public override string GetDescription()
        {
            return "checks for the appearence of the HP keylogger, if it found the keylogger this option will disable it";
        }

        public override bool IsEnabled()
        {
            return false;
        }

        //for the reference: https://thehackernews.com/2017/05/hp-audio-driver-laptop-keylogger.html
        public async override void Apply()
        {

            GetButton().Enabled = false;

            bool appliance = await Task.Run(() => ApplyAsync());

            if (appliance)
            {
                ((RunProgressbar)GetProgressbar()).RunOnceAnimationAsync();
            }
            GetButton().Enabled = true;
        }

        public bool ApplyAsync()
        {

            //begin check SynTP keylogger check...

            RegistryKey checkkey1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"\Software\Synaptics\SynTP");
            RegistryKey checkkey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"\Software\Synaptics\SynTP");
            
            //todo: add version check and value check... this isn't very good.
            if(File.Exists(@"C:\windows\system32\drivers\SynTP.sys") || File.Exists(@"C:\windows\syswow64\drivers\SynTP.sys") || checkkey1 != null || checkkey2 != null)
            {
                MessageBox.Show("warning there are signs you are probably infected by a HP keylogger\nplease update your Synaptics touch driver via HP their site!\n\nsince this keylogger is harder to detect this error could be false alarm.", "warning");
            }

            //end check

            //begin audio driver keylogger mictray

            if (File.Exists(@"C:\Windows\System32\MicTray.exe") || File.Exists(@"C:\Windows\System32\MicTray64.exe"))
            {

                //begin check version 1.0.0.46

                int badvalue = 10046;

                string bit32 = @"C:\Windows\System32\MicTray.exe";
                string bit64 = @"C:\Windows\System32\MicTray64.exe";

                int version32 = Int32.Parse(FileVersionInfo.GetVersionInfo(bit32).ProductVersion.Replace(".", ""));
                int version64 = Int32.Parse(FileVersionInfo.GetVersionInfo(bit64).ProductVersion.Replace(".", ""));

                if(version32 <= badvalue || version64 <= badvalue)
                {
                    //end of version check
                    MessageBox.Show("we are removing HP's audio driver from your system along with the keylogs NOTE: a newer version of this driver contains a patch\nplease note that after a restart you need to check if these files still exist in:\n\nC:\\Windows\\System32\\MicTray.exe\nC:\\Windows\\System32\\MicTray64.exe\n\nif these files exist after reboot please make a issue on our github page!", "Your system is vulnerable!");

                    //first kill all processes before removing the files
                    KillProcesses();

                    File.Delete(@"C:\Windows\System32\MicTray.exe");
                    File.Delete(@"C:\Windows\System32\MicTray64.exe");

                    string[] users = Directory.GetDirectories(@"C:\Users\");

                    foreach (string user in users)
                    {
                        if (File.Exists(user + @"\" + @"MicTray.log"))
                        {
                            File.Delete(user + @"\" + @"MicTray.log");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("there is no reason to worry about an HP keylogger! :)", "Your pc is safe!");
                return true;
            }
            //end check
            return false;
        }

        private void KillProcesses()
        {
            Process[] p1 = Process.GetProcessesByName("MicTray");
            Process[] p2 = Process.GetProcessesByName("MicTray64");
            if(p1 != null)
            {
                foreach(Process p in p1)
                {
                    p.Close();
                    p.Dispose();
                }
            }
            if(p2 != null)
            {
                foreach (Process p in p1)
                {
                    p.Close();
                    p.Dispose();
                }
            }
        }

        public override void Unapply()
        {
            throw new NotImplementedException();
        }

        public override Button GetButton()
        {
            return gui.HPCheckbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.HPCheckProgress;
        }
    }
}
