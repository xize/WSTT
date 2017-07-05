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

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class KeepassAdminPolicy : OptionalPolicy
    {

        private string certificate_hash = "8B602261C22C8855BF5694A6CF742AF27F618930";

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "downloads Keepass and modifies Keepass so that it runs as administrator and uses a different SID(Security Identifier) than the default user.\nthis will make it harder to get unauthorized memory access to KeePass when it is open.";
        }

        public override OptionalPolicyType getType()
        {
            return OptionalPolicyType.KEEPASS_ADMIN_POLICY;
        }

        public override bool isEnabled()
        {
            return File.Exists(@"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe"); //TODO: make it compatible with more harddrives or force it to be installed on the c: drive.
        }

        public override void apply()
        {
            getButton().Enabled = false;

            WebClient c = new WebClient();

            //first read the rss feed to check the latest keepass setup file, then download the installer and check the certificate.
            string body = c.DownloadString("https://sourceforge.net/projects/keepass/rss?path=/KeePass%202.x");
            Regex regex = new Regex("<link>https://sourceforge.net/projects/keepass/files/KeePass%202.x/(.*?)/KeePass-(.*?)-Setup.exe/download</link>");

            if(regex.IsMatch(body))
            {
                string url = regex.Matches(body).OfType<Match>().Select(m => m.Groups[0].Value).ToArray()[0].Replace("<link>", "").Replace("</link>", "");

                if (!Directory.Exists(Config.getConfig().getDataFolder() + @"\wstt-downloaded\KeePass.exe"))
                {
                    Directory.CreateDirectory(Config.getConfig().getDataFolder() + @"\wstt-downloaded");
                }

                c.DownloadFile(new Uri(url), Config.getConfig().getDataFolder() + @"\wstt-downloaded\KeePass.exe");
                X509Certificate cert = X509Certificate.CreateFromSignedFile(Config.getConfig().getDataFolder() + @"\wstt-downloaded\KeePass.exe");
                if(cert.GetCertHashString() == certificate_hash)
                {
                    Process p = Process.Start(Config.getConfig().getDataFolder() + @"\wstt-downloaded\KeePass.exe");
                    p.WaitForExit();
                    p.Dispose();
                    RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\", true);
                    RegistryKey layers = key.OpenSubKey("layers", true);
                    if(layers == null)
                    {
                       layers = key.CreateSubKey("layers");
                    }
                    layers.SetValue(@"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe", "~ RUNASADMIN");
                    layers.Close();
                    layers.Dispose();
                    key.Close();
                    key.Dispose();
                } else
                {
                    File.Delete(Config.getConfig().getDataFolder() + @"\wstt-downloaded\KeePass.exe");
                    MessageBox.Show("Failed to download keepass the certificate did not match!", "invalid certificate!");
                    getButton().Enabled = true;
                    return;
                }
            }

            getButton().Enabled = true;
            getButton().Text = "undo";
            getProgressbar().Value = 100;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            Process p = Process.Start(@"C:\Program Files (x86)\KeePass Password Safe 2\unins000.exe");
            p.WaitForExit();
            p.Dispose();
            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\layers", true);
            key.DeleteValue(@"C:\Program Files (x86)\KeePass Password Safe 2\KeePass.exe");
            key.Close();
            key.Dispose();

            getButton().Enabled = true;
            getButton().Text = "apply";
            getProgressbar().Value = 0;
        }

        public override Button getButton()
        {
            return gui.keepassbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.keepassprogress;
        }
    }
}
