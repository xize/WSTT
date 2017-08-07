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
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.Properties;
using windows_security_tweak_tool.src.libs.gzip_api;
using windows_security_tweak_tool.src.libs.permission_api;

namespace windows_security_tweak_tool.src.policies
{
    class Regsvr32ProxyPolicy : SecurityPolicy
    {
        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "proxies regsvr32 to harden security against registering non dll/exe files";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.REGSERVR32_PROXY_POLICY;
        }

        public override bool isEnabled()
        {
            string customsvr = GetHash(Resources.regsvr32);

            //start recovery procedure
            if(!File.Exists(@"c:\windows\system32\regsvr32.exe") && File.Exists(@"c:\windows\system32\regsvr32.exe.bak") || !File.Exists(@"c:\windows\syswow64\regsvr32.exe") && File.Exists(@"c:\windows\syswow64\regsvr32.exe"))
            {
                File.Move(@"c:\windows\system32\regsvr32.exe.bak", @"c:\windows\system32\regsvr32.exe");
                File.Delete(@"c:\windows\system32\regsvr32.exe");
                if (File.Exists(@"c:\windows\syswow64\regsvr32.exe.bak"))
                {
                    File.Move(@"c:\windows\syswow64\regsvr32.exe.bak", @"c:\windows\syswow64\regsvr32.exe");
                    File.Delete(@"c:\windows\syswow64\regsvr32.exe");
                }
            }
            //end recovery procedure
            string orginalsvr = GetHash(@"C:\windows\system32\regsvr32.exe");

            bool match32bit = (customsvr == orginalsvr);

            if (Environment.Is64BitOperatingSystem)
            {
                string customsvr64 = GetHash(File.ReadAllBytes(@"C:\windows\syswow64\regsvr32.exe")); // <- never understood Microsoft reasoning to still call it regsvr32 instead of regsvr64
                bool match64bit = (customsvr == customsvr64);

                return (match32bit && match64bit);
            } else
            {
                return match32bit;
            }
        }

        public async override void apply()
        {
            getButton().Enabled = false;
            DialogResult r = MessageBox.Show("this policy is extremely experimental and not recommend to use at any time!\n\nthe reason why this policy is not recommend is because it ends up removing system files\npress OK to continue and cancel to avoid losing system files!","warning!", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                await Task.Run(() => ApplyAsync());
                setGuiEnabled(this);
            }
            getButton().Enabled = true;
        }

        private void ApplyAsync()
        {
            string allowedchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder key = new StringBuilder();
            Random rd = new Random();

            for (int i = 0; i < 18; i++)
            {
                key.Append(allowedchars[rd.Next(0, allowedchars.Length)]);
            }

            string name = Convert.ToBase64String(Encoding.UTF8.GetBytes(key.ToString().ToCharArray()));

            string compress = Gzip.GetGzipApi().Compress(name);

            FileStream fs = File.OpenWrite(getDataFolder() + @"\proxy.dat");
            fs.Write(Encoding.UTF8.GetBytes(compress), 0, Encoding.UTF8.GetBytes(compress).Length);
            fs.Close();
            fs.Dispose();

            Permission.GetPermissionAPI().SetToAdministrator(@"c:\windows\system32\regsvr32.exe");

            //first make a backup of regsvr32 since regsvr32 cannot be restored through dism or sfc!
            File.Copy(@"C:\windows\system32\regsvr32.exe", @"C:\windows\system32\regsvr32.exe.bak");

            MessageBox.Show("the name of the new file is: "+name+".exe", "debug message:");

            File.Move(@"c:\windows\system32\regsvr32.exe", @"c:\windows\system32\" + name + ".exe");

            Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"c:\windows\system32\" + name + ".exe");

            if (Environment.Is64BitOperatingSystem)
            {
                Permission.GetPermissionAPI().SetToAdministrator(@"c:\windows\syswow64\regsvr32.exe");
                //first make a backup of regsvr32 since regsvr32 cannot be restored through dism or sfc!
                File.Copy(@"C:\windows\syswow64\regsvr32.exe", @"C:\windows\syswow64\regsvr32.exe.bak");
                File.Move(@"c:\windows\syswow64\regsvr32.exe", @"c:\windows\syswow64\" + name + ".exe");
                Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"c:\windows\syswow64\" + name + ".exe");
            }

            byte[] proxysvr = Resources.regsvr32;

            FileStream pfs = new FileStream(@"c:\windows\system32\regsvr32.exe", FileMode.CreateNew);

            pfs.Write(proxysvr, 0, proxysvr.Length);
            pfs.Close();
            pfs.Dispose();

            Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"c:\windows\system32\regsvr32.exe");

            if (Environment.Is64BitOperatingSystem)
            {
                FileStream pfs64 = new FileStream(@"c:\windows\syswow64\regsvr32.exe", FileMode.CreateNew);

                pfs64.Write(proxysvr, 0, proxysvr.Length);
                pfs64.Close();
                pfs64.Dispose();
                Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"c:\windows\syswow64\regsvr32.exe");
            }

            //remove rollback backup
            File.Delete(@"c:\windows\system32\regsvr32.exe.bak");
            if(Environment.Is64BitOperatingSystem)
            {
                File.Delete(@"c:\windows\syswow64\regsvr32.exe.bak");
            }
        }

        public async override void unapply()
        {
            getButton().Enabled = false;
            await Task.Run(() => UnApplyAsync());
            setGuiDisabled(this);
            getButton().Enabled = true;
        }

        private void UnApplyAsync()
        {
            string name = Gzip.GetGzipApi().Decompress(File.ReadAllText(getDataFolder() + @"\proxy.dat"));

            File.Delete(@"C:\windows\system32\regsvr32.exe");
            if (Environment.Is64BitOperatingSystem)
            {
                File.Delete(@"C:\windows\syswow64\regsvr32.exe");
            }
            File.Move(@"c:\windows\system32\" + name + ".exe", @"c:\windows\system32\regsvr32.exe");
            if (Environment.Is64BitProcess)
            {
                File.Move(@"c:\windows\syswow64\" + name + ".exe", @"c:\windows\syswow64\regsvr32.exe");
            }
            File.Delete(getDataFolder() + @"\proxy.dat");
        }

        private string GetHash(string file)
        {
            byte[] hash = SHA512.Create().ComputeHash(File.ReadAllBytes(file));
            StringBuilder build = new StringBuilder();
            for(int i = 0; i < hash.Length; i++)
            {
                build.Append(hash[i].ToString("X2"));
            }
            return build.ToString();
        }

        private string GetHash(byte[] file)
        {
            byte[] hash = SHA512.Create().ComputeHash(file);
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                build.Append(hash[i].ToString("X2"));
            }
            return build.ToString();
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
            return false;
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
            return gui.regsvr32btn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.regsvr32progress;
        }
    }
}
