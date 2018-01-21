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
using windows_security_tweak_tool.src.certificates;
using windows_security_tweak_tool.src.libs.gzip_api;
using windows_security_tweak_tool.src.libs.permission_api;
using windows_security_tweak_tool.src.libs.windowslock;

namespace windows_security_tweak_tool.src.policies
{
    class Regsvr32ProxyPolicy : SecurityPolicy
    {
        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "proxies regsvr32 to harden security against registering non dll/exe files";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return null /* SecurityPolicyType.REGSERVR32_PROXY_POLICY*/;
        }

        public override bool IsEnabled()
        {
            string customsvr = GetHash(Resources.regsvr32proxy);

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

        public async override void Apply()
        {
            GetButton().Enabled = false;
            DialogResult r = MessageBox.Show("this policy is extremely experimental and we do not recommend to use this at any time!\n\nthe reason why this policy is not recommend is because it could end up removing system files or it could weaken the security permissions for these system files!\n\nfor this reason it is very encouraged to make a backup from the following files:\n\nC:\\windows\\system32\\Regsvr32.exe\nC:\\windows\\syswow64\\Regsvr32.exe\n\npress OK to continue and cancel to avoid losing system files these cannot be restored by sfc or dism!","warning!", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                await Task.Run(() => ApplyAsync());
                SetGuiEnabled(this);
            }
            GetButton().Enabled = true;
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

            FileStream fs = File.OpenWrite(GetDataFolder() + @"\proxy.dat");
            fs.Write(Encoding.UTF8.GetBytes(compress), 0, Encoding.UTF8.GetBytes(compress).Length);
            fs.Close();
            fs.Dispose();

            //first make a backup of regsvr32 since regsvr32 cannot be restored through dism or sfc!
            WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\system32\regsvr32.exe");
            File.Copy(@"C:\windows\system32\regsvr32.exe", @"C:\windows\system32\regsvr32.exe.bak");
            File.Move(@"c:\windows\system32\regsvr32.exe", @"c:\windows\system32\" + name + ".exe");

            if (Environment.Is64BitOperatingSystem)
            {
                WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\syswow64\regsvr32.exe");
                //first make a backup of regsvr32 since regsvr32 cannot be restored through dism or sfc!
                File.Copy(@"C:\windows\syswow64\regsvr32.exe", @"C:\windows\syswow64\regsvr32.exe.bak");
                File.Move(@"c:\windows\syswow64\regsvr32.exe", @"c:\windows\syswow64\" + name + ".exe");
            }

            byte[] proxysvr = Resources.regsvr32proxy;

            FileStream pfs = new FileStream(@"c:\windows\system32\regsvr32.exe", FileMode.CreateNew);

            pfs.Write(proxysvr, 0, proxysvr.Length);
            pfs.Close();
            pfs.Dispose();

            byte[] proxysvrwatchdog = Resources.regsvr32watchdog;

            FileStream pfs2 = new FileStream(@"C:\windows\system32\regsvr32watchdog.exe", FileMode.CreateNew);

            pfs2.Write(proxysvrwatchdog, 0, proxysvrwatchdog.Length);
            pfs2.Close();
            pfs2.Dispose();

            WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\system32\regsvr32.exe");
            WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\system32\regsvr32watchdog.exe");
            //Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"c:\windows\system32\regsvr32.exe");
            //Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"C:\windows\system32\regsvr32watchdog.exe");

            if (Environment.Is64BitOperatingSystem)
            {
                FileStream pfs64 = new FileStream(@"c:\windows\syswow64\regsvr32.exe", FileMode.CreateNew);

                pfs64.Write(proxysvr, 0, proxysvr.Length);
                pfs64.Close();
                pfs64.Dispose();

                FileStream pfs642 = new FileStream(@"c:\windows\syswow64\regsvr32watchdog.exe", FileMode.CreateNew);

                pfs642.Write(proxysvrwatchdog, 0, proxysvrwatchdog.Length);
                pfs642.Close();
                pfs642.Dispose();
                WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\syswow64\regsvr32.exe");
                WindowsLock.GetWindowsFileLock().Lock(@"C:\windows\syswow64\regsvr32watchdog.exe");
                //Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"c:\windows\syswow64\regsvr32.exe");
                //Permission.GetPermissionAPI().RestoreToTrustedInstaller(@"c:\windows\syswow64\regsvr32watchdog.exe");
            }

            //remove rollback backup
            File.Delete(@"c:\windows\system32\regsvr32.exe.bak");
            if(Environment.Is64BitOperatingSystem)
            {
                File.Delete(@"c:\windows\syswow64\regsvr32.exe.bak");
            }
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;
            await Task.Run(() => UnApplyAsync());
            SetGuiDisabled(this);
            GetButton().Enabled = true;
        }

        private void UnApplyAsync()
        {
            string name = Gzip.GetGzipApi().Decompress(File.ReadAllText(GetDataFolder() + @"\proxy.dat"));

            WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\system32\regsvr32.exe");
            WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\system32\regsvr32watchdog.exe");
            File.Delete(@"C:\windows\system32\regsvr32.exe");
            File.Delete(@"C:\windows\system32\regsvr32watchdog.exe");
            if (Environment.Is64BitOperatingSystem)
            {
                WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\syswow64\regsvr32.exe");
                WindowsLock.GetWindowsFileLock().Unlock(@"C:\windows\syswow64\regsvr32watchdog.exe");
                File.Delete(@"C:\windows\syswow64\regsvr32.exe");
                File.Delete(@"C:\windows\syswow64\regsvr32watchdog.exe");
            }
            WindowsLock.GetWindowsFileLock().Unlock(@"c:\windows\system32\" + name + ".exe");
            File.Move(@"c:\windows\system32\" + name + ".exe", @"c:\windows\system32\regsvr32.exe");
            WindowsLock.GetWindowsFileLock().Lock(@"c:\windows\system32\regsvr32.exe");
            if (Environment.Is64BitProcess)
            {
                WindowsLock.GetWindowsFileLock().Unlock(@"c:\windows\syswow64\" + name + ".exe");
                File.Move(@"c:\windows\syswow64\" + name + ".exe", @"c:\windows\syswow64\regsvr32.exe");
                WindowsLock.GetWindowsFileLock().Lock(@"c:\windows\syswow64\regsvr32.exe");
            }
            File.Delete(GetDataFolder() + @"\proxy.dat");
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
            return true;
        }

        public override Button GetButton()
        {
            return gui.regsvr32btn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.regsvr32progress;
        }
    }
}
