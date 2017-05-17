using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies
{
    class SMBSharingPolicy : SecurityPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disable SMB sharing to block ransomware and malware which spreads across networks";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.SMB_SHARING_POLICY;
        }

        public override bool isEnabled()
        {
            if (Config.getConfig().nodeExist("smb-enabled"))
            {
                return Config.getConfig().getBoolean("smb-enabled");
            }
            else
            {
                ProcessStartInfo info = new ProcessStartInfo("dism.exe");
                info.Arguments = "/online /Get-FeatureInfo /FeatureName:SMB1Protocol";
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                info.RedirectStandardOutput = true;
                Process p = Process.Start(info);

                string output = "";
                output = p.StandardOutput.ReadToEnd();

                p.WaitForExit();
                p.Close();
                p.Dispose();
                if (output.ToLower().Contains("disable"))
                {
                    return true;
                }
            }
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;
            ProcessStartInfo info = new ProcessStartInfo("dism.exe");
            info.Arguments = "/Online /Disable-Feature /FeatureName:SMB1Protocol";
            info.UseShellExecute = false;
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Close();
            p.Dispose();
            Config.getConfig().put("smb-enabled", true);
            getButton().Enabled = true;
            setGuiEnabled(this);
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            ProcessStartInfo info = new ProcessStartInfo("dism.exe");
            info.Arguments = "/Online /Enable-Feature /FeatureName:SMB1Protocol";
            info.UseShellExecute = false;
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Close();
            p.Dispose();
            Config.getConfig().put("smb-enabled", false);
            getButton().Enabled = true;
            setGuiDisabled(this);
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

        public override Button getButton()
        {
            return this.gui.smbbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return this.gui.smbprogress;
        }
    }
}
