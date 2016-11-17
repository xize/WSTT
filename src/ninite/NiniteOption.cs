using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.ninite
{
    class NiniteOption
    {

        private static HashSet<NiniteOption> data = new HashSet<NiniteOption>();

        public static NiniteOption SKYPE = new NiniteOption("skype", Program.getGui().niniteskypecheckbox);
        public static NiniteOption ESSENTIALS = new NiniteOption("essentials", Program.getGui().niniteessentialscheckbox);
        public static NiniteOption CLASSIC_START = new NiniteOption("classicstart", Program.getGui().niniteclassiccheckbox);
        public static NiniteOption WINSCP = new NiniteOption("winscp", Program.getGui().winscpcheckbox);
        public static NiniteOption THUNDERBIRD = new NiniteOption("thunderbird", Program.getGui().ninitethunderbirdcheckbox);
        public static NiniteOption MALWAREBYTES = new NiniteOption("malwarebytes", Program.getGui().ninitembamcheckbox);
        public static NiniteOption SEVENZIP = new NiniteOption("7zip", Program.getGui().ninite7zipcheckbox);
        public static NiniteOption PUTTY = new NiniteOption("putty", Program.getGui().niniteputtycheckbox);
        public static NiniteOption ITUNES = new NiniteOption("itunes", Program.getGui().niniteitunescheckbox);
        public static NiniteOption DROPBOX = new NiniteOption("dropbox", Program.getGui().ninitedropboxcheckbox);
        public static NiniteOption WINRAR = new NiniteOption("winrar", Program.getGui().ninitewinrarcheckbox);
        public static NiniteOption VLCPLAYER = new NiniteOption("vlc", Program.getGui().ninitevlcplayercheckbox);
        public static NiniteOption GOOGLE_DRIVE = new NiniteOption("googledrive", Program.getGui().ninitegoogledrivecheckbox);
        public static NiniteOption FILEZILLA = new NiniteOption("filezilla", Program.getGui().ninitefilezillacheckbox);
        public static NiniteOption SPOTIFY = new NiniteOption("spotify", Program.getGui().ninitespotifycheckbox);
        public static NiniteOption IMGBURN = new NiniteOption("imgburn", Program.getGui().niniteimgburncheckbox);
        public static NiniteOption NOTEPAD_PLUS_PLUS = new NiniteOption("notepadplusplus", Program.getGui().ninitenotepadcheckbox);

        private string name;
        private CheckBox box;

        private NiniteOption(string name, CheckBox box)
        {
            this.name = name;
            this.box = box;
            data.Add(this);
        }

        public string getName()
        {
            return name;
        }

        public CheckBox getCheckbox()
        {
            return box;
        }

        public bool isEnabled()
        {
            return box.Enabled;
        }

        public static NiniteOption valueOf(string name)
        {
            foreach(NiniteOption option in values())
            {
                if(name.ToLower().StartsWith(option.getName().ToLower()))
                {
                    return option;
                }
            }
            throw new ArgumentNullException("cannot find "+name.ToLower()+" as option");
        }

        public static NiniteOption[] values()
        {
            return data.ToArray();
        }

    }
}
