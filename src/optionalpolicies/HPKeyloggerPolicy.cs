using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.optionalpolicies
{
    class HPKeyloggerPolicy : OptionalPolicy
    {
        public override string getName()
        {
            return getType().getName();
        }

        public override OptionalPolicyType getType()
        {
            return OptionalPolicyType.HP_KEYLOGGER;
        }

        public override string getDescription()
        {
            return "checks for the appearence of the HP keylogger, if it found the keylogger this option will disable it";
        }

        public override bool isEnabled()
        {
            return false;
        }

        //for the reference: https://thehackernews.com/2017/05/hp-audio-driver-laptop-keylogger.html
        public override void apply()
        {
            if (File.Exists(@"C:\Windows\System32\MicTray.exe") || File.Exists(@"C:\Windows\System32\MicTray64.exe"))
            {
                getButton().Enabled = false;

                MessageBox.Show("we are removing files from your system\nplease note that after a restart you need to check if these files still exist in:\n\nC:\\Windows\\System32\\MicTray.exe\nC:\\Windows\\System32\\MicTray64.exe\n\nif these files exist after reboot please make a issue on our github page!", "Your system is vulnerable!");
                File.Delete(@"C:\Windows\System32\MicTray.exe");
                File.Delete(@"C:\Windows\System32\MicTray64.exe");

                string maindir = @"C:\Users\";
                string[] users = Directory.GetDirectories(@"C:\Users\");

                foreach(string user in users)
                {
                    if(File.Exists(user+@"\"+ @"MicTray.log"))
                    {
                        File.Delete(user+@"\"+ @"MicTray.log");
                    }
                }

                getButton().Enabled = true;
                getProgressbar().Value = 100;
            } else
            {
                MessageBox.Show("there is no reason to worry about an HP keylogger! :)", "Your pc is safe!");
            }
        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }

        public override Button getButton()
        {
            return gui.HPCheckbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.HPCheckProgress;
        }
    }
}
