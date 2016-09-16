/*
    A security toolkit for windows    

    Copyright(C) 2016 Guido Lucassen

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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class RenamePolicy : Policy
    {

        private string[] extensions =
        {
            //scripts, however there are alot more but I lost the article....
            ".js",
            ".jse",
            ".vbs",
            ".wsh",
            ".wsc",
            ".vbx",
            ".vba",
            ".vb",
            ".vbe",
            ".ws",
            ".ocx",
            ".scr",
            ".pif",
            ".ps1", //since this is default set to notepad in alot of windows versions, older non updated versions still use ps1 as powershell application, for this reason keep patching it to notepad
            //macros need to be blocked aswell :)
            ".docm",
            ".dotm",
            ".pptm",
            ".xlm",
            ".xlsm"
        };

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "renames the default program for the following extensions:\n"+string.Join(",", extensions)+"\n\nthis megitates code what can be load from javascript as a vbs script, this also disables macros";
        }


        public override PolicyType getType()
        {
            return PolicyType.RENAME_POLICY;
        }

        public override bool isEnabled()
        {
            if(Config.getConfig().getBoolean("renamed"))
            {
                return true;
            }
            return false;
        }

        public override void apply()
        {
            getButton().Enabled = false;

            foreach(string extension in extensions)
            {
                ProcessStartInfo assoc = new ProcessStartInfo("cmd.exe");
                assoc.Arguments = "/c assoc " + extension+"="+extension.ToUpper()+"File";
                assoc.CreateNoWindow = true;
                Process proc1 = Process.Start(assoc);

                while (proc1.HasExited) { } ////lock the local thread till the process has been ended.

                ProcessStartInfo ftype = new ProcessStartInfo("cmd.exe");
                ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\windows\system32\notepad.exe";
                ftype.CreateNoWindow = true;
                Process proc2 = Process.Start(ftype);

                while (proc2.HasExited) { } //lock the local thread till the process has been ended.
            }

            Config.getConfig().put("renamed", true);
            getButton().Enabled = true;
        }

        public override void unapply()
        {
            getButton().Enabled = false;

            foreach (string extension in extensions)
            {
                ProcessStartInfo assoc = new ProcessStartInfo("cmd.exe");
                assoc.Arguments = "/c assoc " + extension + "=" + extension.ToUpper() + "File";
                assoc.CreateNoWindow = true;
                Process proc1 = Process.Start(assoc);

                while (proc1.HasExited) { } ////lock the local thread till the process has been ended.

                ProcessStartInfo ftype = new ProcessStartInfo("cmd.exe");

                switch (extension)
                {
                    //TODO: figuring out how these macros work..... which program it uses to be exact.
                    case ".docm":
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Program Files (x86)\Microsoft Office\root\Office16\winword.exe";
                        break;
                    case ".dotm":
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Program Files (x86)\Microsoft Office\root\Office16\winword.exe";
                        break;
                    case ".pptm":
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Program Files (x86)\Microsoft Office\root\Office16\powerpoint.exe";
                        break;
                    case ".xlm":
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Program Files (x86)\Microsoft Office\root\Office16\Excel.exe";
                        break;
                    case ".xlsm":
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Program Files (x86)\Microsoft Office\root\Office16\Excel.exe";
                        break;
                    case ".ps1":
                        //do nothing ps1 is already as default megitated to notepad.
                        break;
                    default:
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Windows\System32\wscript.exe";
                        break;
                }

                ftype.CreateNoWindow = true;
                Process proc2 = Process.Start(ftype);

                while (proc2.HasExited) { } //lock the local thread till the process has been ended.
            }
            Config.getConfig().put("renamed", false);
            getButton().Enabled = true;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override Button getButton()
        {
            return gui.renamebtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.renameprogress;
        }
    }
}
