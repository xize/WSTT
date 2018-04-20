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
	//TODO: manually load the addons as tabs into chrome, chrome doesn't allow drag and drop anymore, deprecated this class for now
	[Obsolete]
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
            new ChromeAddon("windowsdefender", "bkbeeeffjjeopflfhgeknacdieedcoml")
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
        	foreach(ChromeAddon addon in addons) {
        		addon.OpenTab();
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
    
   public class ChromeAddon {
   	
   	private string name;
   	private string id;
   	private string url = "https://chrome.google.com/webstore/detail/{0}";
   	
   	public ChromeAddon(string name, string id) {
   		this.name = name;
   		this.id = id;
   	}
   	
   	public void OpenTab() {
   		ProcessStartInfo info = new ProcessStartInfo("chrome.exe");
   		info.Arguments = String.Format(this.url, this.id);
   		Process p = Process.Start(info);
   	}
   	
   }
}
