using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class Chrome64bitPolicy : OptionalPolicy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "installs a more hardened version of google chrome";
        }

        public override OptionalPolicyType getType()
        {
            return OptionalPolicyType.CHROME_64BIT_POLICY;
        }

        public override bool isEnabled()
        {
           return File.Exists(@"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe");
        }

        public override bool isCertificateDepended()
        {
            return true;
        }

        public override Certificate getCertificate()
        {
            return CertProvider.GOOGLE_CHROME.getCertificate();
        }

        public override void apply()
        {
            getButton().Enabled = false;
            if(!Directory.Exists(Config.getConfig().getDataFolder() + @"\wstt-downloaded"))
            {
                Directory.CreateDirectory(Config.getConfig().getDataFolder() + @"\wstt-downloaded");
            }

            WebClient client = new WebClient();
            client.DownloadFile("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B03FE9563-80F9-119F-DA3D-72FBBB94BC26%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable%26brand=GCEB/dl/chrome/install/GoogleChromeEnterpriseBundle64.zip", Config.getConfig().getDataFolder()+@"\wstt-downloaded\chrome.zip");
            FileStream fs = File.OpenRead(Config.getConfig().getDataFolder() + @"\wstt-downloaded\chrome.zip");
            ZipArchive archive = new ZipArchive(fs);
            archive.ExtractToDirectory(Config.getConfig().getDataFolder()+@"\wstt-downloaded\chrome");
            fs.Close();
            fs.Dispose();
            archive.Dispose();

            X509Certificate cert = X509Certificate.CreateFromSignedFile(Config.getConfig().getDataFolder() + @"\wstt-downloaded\chrome\Installers\GoogleChromeStandaloneEnterprise64.msi");
            if(cert.GetCertHashString() == getCertificate().getHash())
            {
                Process p = Process.Start(Config.getConfig().getDataFolder() + @"\wstt-downloaded\chrome\Installers\GoogleChromeStandaloneEnterprise64.msi");
                p.WaitForExit();
                p.Dispose();
                if (File.Exists(@"C:\Program Files (x86)\Google\Chrome\Application\Chrome.exe"))
                {
                    getButton().Text = "undo";
                    getProgressbar().Value = 100;
                }
                Directory.Delete(Config.getConfig().getDataFolder() + @"\wstt-downloaded\chrome", true);
                File.Delete(Config.getConfig().getDataFolder() + @"\wstt-downloaded\chrome.zip");
            } else
            {
               Directory.Delete(Config.getConfig().getDataFolder() + @"\wstt -downloaded\chrome", true);
               File.Delete(Config.getConfig().getDataFolder() + @"\wstt-downloaded\chrome.zip");
                MessageBox.Show("The signed certificate did not match with the downloaded file!", "Invalid certificate or revoked!");
            }
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;
            ProcessStartInfo info = new ProcessStartInfo("wmic.exe");
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.Arguments = "product where name=\"Google Chrome\" call uninstall";
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Dispose();
            getButton().Text = "apply";
            getProgressbar().Value = 0;
            getButton().Enabled = true;
        }

        public override Button getButton()
        {
            return gui.chromebtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.chromeprogress;
        }
    }
}
