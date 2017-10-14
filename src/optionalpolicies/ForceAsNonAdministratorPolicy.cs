using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class ForceAsNonAdministratorPolicy : OptionalPolicy
    {

        public override string GetName()
        {
            return GetOptionalPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "adds a right click context menu option which enables a function to force programs to run under non administrator rights";
        }

        public override OptionalPolicyType GetOptionalPolicyType()
        {
            return OptionalPolicyType.FORCE_NON_ADMINISTRATOR_POLICY;
        }

        public override bool IsEnabled()
        {
            RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, (Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32)).OpenSubKey(@"*\shell");
            if(root.OpenSubKey("forcenonadministrator") != null)
            {
                root.Close();
                root.Dispose();
                return true;
            }
            root.Close();
            root.Dispose();
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            GetButton().Text = "undo";
            GetButton().Enabled = true;
            GetProgressbar().Value = 100;
        }

        public void ApplyAsync()
        {
            RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, (Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32)).OpenSubKey(@"*\shell", true);
            RegistryKey progkey = root.CreateSubKey("forcenonadministrator");
            progkey.SetValue("", "Force run as non administrator");
            RegistryKey command = progkey.CreateSubKey("command");
            command.SetValue("", "cmd.exe /c /min set __COMPAT_LAYER=RUNASINVOKER && start %1");

            command.Close();
            command.Dispose();
            progkey.Close();
            progkey.Dispose();
            root.Close();
            root.Dispose();
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            GetButton().Text = "apply";
            GetButton().Enabled = true;
            GetProgressbar().Value = 0;
        }

        public void UnapplyAsync()
        {
            RegistryKey root = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, (Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32)).OpenSubKey(@"*\shell", true);
            root.DeleteSubKeyTree("forcenonadministrator");
            root.Close();
            root.Dispose();
        }

        public override Button GetButton()
        {
            return this.gui.forcenonadminbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return this.gui.forcenonadminprogress;
        }
    }
}
