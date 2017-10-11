using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class PowershellPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return this.GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disables powershell for being able to execute\n\nhowever in this version of wstt it only blocks powershell 2.0 and not the default powershell 1.0!";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.POWERSHELL_POLICY;
        }

        public override bool IsEnabled()
        {
            ProcessStartInfo info = new ProcessStartInfo("dism.exe");
            info.Arguments = "/online /Get-Features";
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;
            Process p = Process.Start(info);
            string data = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Dispose();

            string[] lines = data.Split('\n');
            for(int i = 0; i < lines.Length;i++)
            {
                if(lines[i].Contains("Feature Name : MicrosoftWindowsPowerShellV2") || lines[i].Contains("MicrosoftWindowsPowerShellV2Root"))
                {
                    string status = lines[i + 1].Substring("Status : ".Length-1);
                    if(!status.Contains("Enabled"))
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            SetGuiEnabled(this);

            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            ExecuteCMD("dism /online /Disable-Feature /FeatureName:MicrosoftWindowsPowerShellV2", true);
            ExecuteCMD("dism /online /Disable-Feature /FeatureName:MicrosoftWindowsPowerShellV2Root", true);

            //TODO: add also a restriction on C:\windows\system32\WindowsPowershell\v1.0 because windows 10 is installed with 2 versions of powershell whereby version '1.0' is being used as default.
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            SetGuiDisabled(this);

            GetButton().Enabled = true;
        }

        public void UnapplyAsync()
        {
            ExecuteCMD("dism /online /Enable-Feature /FeatureName:MicrosoftWindowsPowerShellV2", true);
            ExecuteCMD("dism /online /Enable-Feature /FeatureName:MicrosoftWindowsPowerShellV2Root", true);

            //TODO: add also a restriction on C:\windows\system32\WindowsPowershell\v1.0 because windows 10 is installed with 2 versions of powershell whereby version '1.0' is being used as default.
        }

        public override bool IsCertificateDepended()
        {
            return false;
        }

        public override Certificate GetCertificate()
        {
            throw new NotImplementedException();
        }

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return false;
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSafeForBussiness()
        {
            return false;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override bool IsUserControlRequired()
        {
            return false;
        }

        public override Button GetButton()
        {
            return gui.powershellbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.powershellprogress;
        }
    }
}
