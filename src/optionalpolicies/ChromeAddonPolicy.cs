using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.controls;

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

        public override string GetName()
        {
            return GetOptionalPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "installs safety addons into google chrome!";
        }

        public override OptionalPolicyType GetOptionalPolicyType()
        {
            return OptionalPolicyType.CHROME_ADDON_POLICY;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            GetButton().Enabled = true;
            ((RunProgressbar)GetProgressbar()).RunOnceAnimationAsync();
        }

        public void ApplyAsync()
        {
            foreach (ChromeAddon addon in addons)
            {
                addon.Download();
            }

            CleanupProcesses();

            Process p = Process.Start("explorer.exe", Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\chrome-addons");
            DialogResult r = MessageBox.Show("please start chrome and paste this url:\n" + "chrome://extensions/" + "\nthen select a single file in this folder and drag it into the page!\n\npress OK when you are done!", "please read!");


            Thread thread = new Thread(() => Clipboard.SetText("chrome://extensions/"));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();

            p.WaitForExit();
            p.Dispose();

            if (r == DialogResult.OK)
            {
                DirectoryInfo dir = new DirectoryInfo(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\chrome-addons");
                foreach (var f in dir.EnumerateFiles("*.crx"))
                {
                    f.Delete();
                }
                //CleanupProcesses();
            }
        }

        private void CleanupProcesses()
        {

            //not sure why I needed to close and restart all explorer windows seems rather pointless since I can't figure out why I do this because it doesn't need to hook into explorer at all....
            //only cleanup for first explorer run so the new explorer window gets spawned in front of the user.

            if (Process.GetProcessesByName("explorer").Length > 0)
            {
                foreach (Process explorer in Process.GetProcessesByName("explorer"))
                {
                    explorer.Kill();
                }
            }
        }

        public override void Unapply()
        {
            throw new NotImplementedException();
        }

        public override Button GetButton()
        {
            return gui.chromeaddonbtn;
        }

        public override ProgressBar GetProgressbar()
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

        public string GetName()
        {
            return this.name;
        }

        public string GetID()
        {
            return this.id;
        }

        public string Download()
        {
            WebClient client = new WebClient();
            if(!Directory.Exists(Config.GetConfig().GetDataFolder()+@"\wstt-downloaded"))
            {
                Directory.CreateDirectory(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded");
            }
            if (!Directory.Exists(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\chrome-addons"))
            {
                Directory.CreateDirectory(Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\chrome-addons");
            }
            client.DownloadFile(api_string.Replace("{id}", id), Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\chrome-addons\"+name+".crx");

            return Config.GetConfig().GetDataFolder() + @"\wstt-downloaded\chrome-addons\" + name + ".crx";
        }
    }
}
