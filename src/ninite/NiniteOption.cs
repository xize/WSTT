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

        public static NiniteOption SKYPE = new NiniteOption("skype", Program.getGui().getOptionalWindow().niniteskypecheckbox);
        public static NiniteOption ESSENTIALS = new NiniteOption("essentials", Program.getGui().getOptionalWindow().niniteessentialscheckbox);
        public static NiniteOption CLASSIC_START = new NiniteOption("classicstart", Program.getGui().getOptionalWindow().niniteclassiccheckbox);
        public static NiniteOption WINSCP = new NiniteOption("winscp", Program.getGui().getOptionalWindow().winscpcheckbox);
        public static NiniteOption THUNDERBIRD = new NiniteOption("thunderbird", Program.getGui().getOptionalWindow().ninitethunderbirdcheckbox);
        public static NiniteOption MALWAREBYTES = new NiniteOption("malwarebytes", Program.getGui().getOptionalWindow().ninitembamcheckbox);
        public static NiniteOption SEVENZIP = new NiniteOption("7zip", Program.getGui().getOptionalWindow().ninite7zipcheckbox);
        public static NiniteOption PUTTY = new NiniteOption("putty", Program.getGui().getOptionalWindow().niniteputtycheckbox);
        public static NiniteOption ITUNES = new NiniteOption("itunes", Program.getGui().getOptionalWindow().niniteitunescheckbox);
        public static NiniteOption DROPBOX = new NiniteOption("dropbox", Program.getGui().getOptionalWindow().ninitedropboxcheckbox);
        public static NiniteOption WINRAR = new NiniteOption("winrar", Program.getGui().getOptionalWindow().ninitewinrarcheckbox);
        public static NiniteOption VLCPLAYER = new NiniteOption("vlc", Program.getGui().getOptionalWindow().ninitevlcplayercheckbox);
        public static NiniteOption GOOGLE_DRIVE = new NiniteOption("googledrive", Program.getGui().getOptionalWindow().ninitegoogledrivecheckbox);
        public static NiniteOption FILEZILLA = new NiniteOption("filezilla", Program.getGui().getOptionalWindow().ninitefilezillacheckbox);
        public static NiniteOption SPOTIFY = new NiniteOption("spotify", Program.getGui().getOptionalWindow().ninitespotifycheckbox);
        public static NiniteOption IMGBURN = new NiniteOption("imgburn", Program.getGui().getOptionalWindow().niniteimgburncheckbox);
        public static NiniteOption NOTEPAD_PLUS_PLUS = new NiniteOption("notepadplusplus", Program.getGui().getOptionalWindow().ninitenotepadcheckbox);

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
            return box.Checked;
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
