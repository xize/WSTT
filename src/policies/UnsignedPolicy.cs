using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class UnsignedPolicy : SecurityPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "scans through every .exe and .dll file and checks if it has been signed with a certificate";
        }

        public override bool isEnabled()
        {
            return false;
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.UNSIGNED_POLICY;
        }

        public override void apply()
        {
            this.setGuiDisabled(this);

            if (!isInstalled())
            {
                Directory.CreateDirectory(getDataFolder() + @"\sigcheck");
                installForFirstTime("sigcheck");
                installForFirstTime("sigcheck64");
                installForFirstTime("sigcheckeula");
            }

            Process proc;

            if (Environment.Is64BitOperatingSystem)
            {
                ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
                sinfo.Arguments = "/c " + getDataFolder() + @"\sigcheck\sigcheck.exe -a -s -u -e C:\windows\system32 > " + getDataFolder() + @"\sigcheck\unsigned.txt";
                proc = Process.Start(sinfo);
            }
            else
            {
                ProcessStartInfo sinfo = new ProcessStartInfo("cmd.exe");
                sinfo.Arguments = "/c " + getDataFolder() + @"\sigcheck\sigcheck.exe -a -s -u -e C:\windows\system32 > " + getDataFolder() + @"\sigcheck\unsigned.txt";
                proc = Process.Start(sinfo);
            }

            while (!proc.HasExited) { }
            proc.Close();
            proc.Dispose();

            ProcessStartInfo info = new ProcessStartInfo("notepad.exe");
            info.Arguments = getDataFolder() + @"\sigcheck\unsigned.txt";
            Process p = Process.Start(info);
        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }


        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        [Obsolete]
        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSafeForBussiness()
        {
            return true;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isUserControlRequired()
        {
            return true;
        }

        private bool isInstalled()
        {
            return Directory.Exists(getDataFolder() + @"\sigcheck");
        }

        private void installForFirstTime(string resource)
        {
            string path = getDataFolder() + @"\sigcheck";

            switch (resource)
            {
                case "sigcheck":
                    File.WriteAllBytes(path + @"\sigcheck.exe", Properties.Resources.sigcheck);
                    break;
                case "sigcheck64":
                    File.WriteAllBytes(path + @"\sigcheck64.exe", Properties.Resources.sigcheck64);
                    break;
                case "sigcheckeula":
                    File.WriteAllBytes(path + @"\Eula.txt", Properties.Resources.sigcheckeula);
                    break;
            }
        }

        public override Button getButton()
        {
            return this.gui.unsignedbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return this.gui.unsignedprogress;
        }
    }
}
