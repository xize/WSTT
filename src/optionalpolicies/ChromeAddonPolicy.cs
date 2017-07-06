using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class ChromeAddonPolicy : OptionalPolicy
    {

        private List<ChromeAddon> addons = new ChromeAddon[]
        {
            new ChromeAddon("chromebleed", "eeoekjnjgppnaegdjbcafdggilajhpic"),
            new ChromeAddon("facebookpostmanager", "ljfidlkcmdmmibngdfikhffffdmphjae"),
            new ChromeAddon("ghostery", "mlomiejdfkolichcflejclcbmpeaniij"),
            new ChromeAddon("httpseverywhere", "gcbommkclmclpchllfjekcdonpmejbdp"),
            new ChromeAddon("passwordalert", "noondiphcddnnabmjcihcjfbhfklnnep"),
            new ChromeAddon("passwordlength", "afoegnmpahaamjgfdphoohihhfhmknng"),
            new ChromeAddon("privacybadger", "pkehgijcmpdhfbdbbnkijodmdjhbjlgp"),
            new ChromeAddon("ublockorigin", "cjpalhdlnbpafiamejdnhcphjbkeiagm"),
            new ChromeAddon("umatrix", "ogfcmafjalglgifnmanfmnieipoejdcf"),
            new ChromeAddon("usragentswitcher", "djflhoibgkdhkhhcedjiklpkjnoahfmg"),
            new ChromeAddon("wheretodeleteanaccount", "hfpofkfbabpbbmchmiekfnlcgaedbgcf"),
        }.ToList();

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "installs safety addons into google chrome!";
        }

        public override OptionalPolicyType getType()
        {
            return OptionalPolicyType.CHROME_ADDON_POLICY;
        }

        public override void apply()
        {
            getButton().Enabled = false;

            foreach(ChromeAddon addon in addons)
            {
               addon.download();
            }

            cleanupProcesses();

            Process p = Process.Start("explorer.exe", Config.getConfig().getDataFolder() + @"\wstt-downloaded\");
            DialogResult r = MessageBox.Show("please start chrome and paste this url:\n" + "chrome://extensions/" + "\nthen select a single file in this folder and drag it into the page!\n\npress OK when you are done!", "please read!");
            Clipboard.SetText("chrome://extensions/");

            p.WaitForExit();
            p.Dispose();

            if(r == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(Config.getConfig().getDataFolder() + @"\wstt-downloaded\");
                foreach(var f in dir.EnumerateFiles("*.crx"))
                {
                    f.Delete();
                }
                cleanupProcesses();
                getButton().Enabled = true;
                getProgressbar().Value = 100;
            }
        }

        private void cleanupProcesses()
        {

            if (Process.GetProcessesByName("explorer").Length > 0)
            {
                foreach (Process explorer in Process.GetProcessesByName("explorer"))
                {
                    explorer.Kill();
                }
            }
        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }

        public override Button getButton()
        {
            return gui.chromeaddonbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.chromeaddonprogress;
        }
    }

    public class ChromeAddon
    {

        private string name;
        private string id;
        private string api_string  = "https://clients2.google.com/service/update2/crx?response=redirect&prodversion=49.0&x=id%3D{id}%26uc";

        public ChromeAddon(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public string getID()
        {
            return this.id;
        }

        public string download()
        {
            WebClient client = new WebClient();
            if(!Directory.Exists(Config.getConfig().getDataFolder()+@"\wstt-downloaded"))
            {
                Directory.CreateDirectory(Config.getConfig().getDataFolder() + @"\wstt-downloaded");
            }
            client.DownloadFile(api_string.Replace("{id}", id), Config.getConfig().getDataFolder() + @"\wstt-downloaded\"+name+".crx");

            return Config.getConfig().getDataFolder() + @"\wstt-downloaded\" + name + ".crx";
        }
    }
}
