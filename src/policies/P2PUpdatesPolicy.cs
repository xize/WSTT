using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class P2PUpdatesPolicy : SecurityPolicy
    {
        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.P2PUPDATE_POLICY;
        }

        public override string GetDescription()
        {
            return "disables p2p shared microsoft windows updates";
        }

        public override bool IsEnabled()
        {
            RegistryKey k = this.GetRegistry(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization", REG.HKLM);

            if (k == null)
            {
                MessageBox.Show("you might use a different version of windows which doesn't support this policy!", "warning");
                this.GetButton().Enabled = false;
                this.GetButton().Text = "unsupported!";
                return false;
            }

            RegistryKey key = k.OpenSubKey("Config");

            if (key != null)
            {

                object e = key.GetValue("DODownloadMode");
                if (e != null)
                {
                    int n = (int)e;
                    if (n == 0)
                    {
                        key.Close();
                        key.Dispose();
                        k.Close();
                        k.Dispose();
                        return true;
                    }
                }

                RegistryKey key2 = k.OpenSubKey("Settings");

                if (key2 != null)
                {

                    object e2 = key2.GetValue("DownloadMode");
                    if (e2 != null)
                    {
                        int n = int.Parse((string)e2);
                        if (n == 0)
                        {
                            key2.Close();
                            key2.Dispose();
                            k.Close();
                            k.Dispose();
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public async override void Apply()
        {
            await Task.Run(() => ApplyAsync());
            SetGuiEnabled(this);
        }

        public void ApplyAsync()
        {
            RegistryKey k = this.GetRegistry(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization", REG.HKLM);
            if (k != null)
            {
                RegistryKey key = k.OpenSubKey("Config", true);
                RegistryKey key2 = k.OpenSubKey("Settings", true);
                if (key == null)
                {
                    k.CreateSubKey("Config");
                }
                if (key2 == null)
                {
                    k.CreateSubKey("Settings");
                }

                key.SetValue("DODownloadMode", 0);
                key.Close();
                key.Dispose();
                key2.SetValue("DownloadMode", 0, RegistryValueKind.String);
                key2.Close();
                key2.Dispose();
            }
            k.Close();
            k.Dispose();
        }

        public async override void Unapply()
        {
            await Task.Run(() => UnapplyAsync());
            SetGuiDisabled(this);
        }

        public void UnapplyAsync()
        {
            RegistryKey k = GetRegistry(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization", REG.HKLM);

            RegistryKey key1 = k.OpenSubKey("Config", true);
            key1.SetValue("DODownloadMode", 1);

            RegistryKey key2 = k.OpenSubKey("Settings", true);
            key2.SetValue("DownloadMode", "1", RegistryValueKind.String);

            key1.Close();
            key1.Dispose();
            key2.Close();
            key2.Dispose();

            k.Close();
            k.Dispose();
        }

        public override Certificate GetCertificate()
        {
            throw new NotImplementedException();
        }

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        public override bool IsCertificateDepended()
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
            return gui.windowsupdatepeerbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.windowsupdatepeerprogress;
        }
    }
}
