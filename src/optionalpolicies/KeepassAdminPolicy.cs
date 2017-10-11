using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class KeepassAdminPolicy : OptionalPolicy
    {

        public override string GetName()
        {
            return GetOptionalPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "downloads Keepass and modifies Keepass so that it runs as administrator and uses a different SID(Security Identifier) than the default user.\nthis will make it harder to get unauthorized memory access to KeePass when it is open.";
        }

        public override OptionalPolicyType GetOptionalPolicyType()
        {
            return OptionalPolicyType.KEEPASS_ADMIN_POLICY;
        }

        public override bool IsEnabled()
        {
            return File.Exists(@"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe"); //TODO: make it compatible with more harddrives or force it to be installed on the c: drive.
        }

        public override bool IsCertificateDepended()
        {
            return true;
        }

        public override Certificate GetCertificate()
        {
            return CertProvider.KEEPASS.GetCertificate();
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            bool status = await Task.Run(() => ApplyAsync());

            if(status)
            {
                GetProgressbar().Value = 100;
                GetButton().Text = "undo";
            }

            GetButton().Enabled = true;

        }

        public bool ApplyAsync()
        {
            MessageBox.Show("please make sure you use the default installation location!", "important");

            WebClient c = new WebClient();

            //first read the rss feed to check the latest keepass setup file, then download the installer and check the certificate.
            string body = c.DownloadString("https://sourceforge.net/projects/keepass/rss?path=/KeePass%202.x");
            Regex regex = new Regex("<link>https://sourceforge.net/projects/keepass/files/KeePass%202.x/(.*?)/KeePass-(.*?)-Setup.exe/download</link>");

            if (regex.IsMatch(body))
            {
                string url = regex.Matches(body).OfType<Match>().Select(m => m.Groups[0].Value).ToArray()[0].Replace("<link>", "").Replace("</link>", "");

                if (!Directory.Exists(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\KeePass.exe"))
                {
                    Directory.CreateDirectory(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded");
                }

                c.DownloadFile(new Uri(url), Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\KeePass.exe");
                X509Certificate cert = X509Certificate.CreateFromSignedFile(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\KeePass.exe");
                if (cert.GetCertHashString() == GetCertificate().GetHash())
                {
                    Process p = Process.Start(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\KeePass.exe");
                    p.WaitForExit();
                    p.Dispose();
                    RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\", true);
                    RegistryKey layers = key.OpenSubKey("layers", true);
                    if (layers == null)
                    {
                        layers = key.CreateSubKey("layers");
                    }
                    layers.SetValue(@"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe", "~ RUNASADMIN");
                    layers.Close();
                    layers.Dispose();
                    key.Close();
                    key.Dispose();
                    File.Delete(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\KeePass.exe");
                    return true;
                }
                else
                {
                    File.Delete(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\KeePass.exe");
                    MessageBox.Show("Failed to download keepass the certificate did not match!", "invalid certificate!");
                    GetButton().Enabled = true;
                }
            }
            return false;
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            GetButton().Enabled = true;
            GetButton().Text = "apply";
            GetProgressbar().Value = 0;
        }

        public void UnapplyAsync()
        {
            Process p = Process.Start(@"C:\Program Files (x86)\KeePass Password Safe 2\unins000.exe");
            p.WaitForExit();
            p.Dispose();
            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\layers", true);
            key.DeleteValue(@"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe");
            key.Close();
            key.Dispose();
        }

        public override Button GetButton()
        {
            return gui.keepassbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.keepassprogress;
        }
    }
}
