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
using windows_tweak_tool.src.utils;

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
            ".wsf",
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
            ".xlsm",
            ".mhtml",
            ".mht",
            ".hta"
            //special cases...
            ".tif",
            ".tiff" //Tempory disable Tiff remote explotation, see: https://threatpost.com/remote-code-execution-vulnerabilities-plague-libtiff-library/121570/ not sure if this is the correct way of megitation!
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

            Console.WriteLine("{== Applying " + getType().getName().ToUpper() + " ==}");

            foreach (string extension in extensions)
            {
                ProcessStartInfo assoc = new ProcessStartInfo("cmd.exe");
                assoc.Arguments = "/c assoc " + extension+"="+extension.ToUpper()+"File";
                assoc.CreateNoWindow = true;
                Process proc1 = Process.Start(assoc);

                while (!proc1.HasExited) { } ////lock the local thread till the process has been ended.

                proc1.Dispose();

                ProcessStartInfo ftype = new ProcessStartInfo("cmd.exe");
                ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\windows\system32\notepad.exe";
                ftype.CreateNoWindow = true;
                Process proc2 = Process.Start(ftype);

                while (!proc2.HasExited) { } //lock the local thread till the process has been ended.
                proc2.Dispose();
                Console.WriteLine("extension: " + extension + " has been defaulted to: " + @"C:\windows\system32\notepad.exe");
            }

            Config.getConfig().put("renamed", true);
            setGuiEnabled(this);
            getButton().Enabled = true;
            Console.WriteLine("{== " + getType().getName().ToUpper() + " has been applied ==}");
        }

        public override void unapply()
        {
            getButton().Enabled = false;

            Console.WriteLine("{== Unapplying Policy " + getType().getName().ToUpper() + " ==}");

            foreach (string extension in extensions)
            {
                ProcessStartInfo assoc = new ProcessStartInfo("cmd.exe");
                assoc.Arguments = "/c assoc " + extension + "=" + extension.ToUpper() + "File";
                assoc.CreateNoWindow = true;
                Process proc1 = Process.Start(assoc);

                while (!proc1.HasExited) { } ////lock the local thread till the process has been ended.
                proc1.Dispose();

                ProcessStartInfo ftype = new ProcessStartInfo("cmd.exe");

                switch (extension)
                {
                    //TODO: figuring out how these macros work..... which program it uses to be exact.
                    case ".docm":
                        Console.WriteLine("extension: "+extension+" gets defaulted to: "+ @"C:\Program Files(x86)\Microsoft Office\root\Office16\winword.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + "File=\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\winword.exe\"";
                        break;
                    case ".dotm":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\Program Files(x86)\Microsoft Office\root\Office16\winword.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + "File=\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\winword.exe\"";
                        break;
                    case ".pptm":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\Program Files(x86)\Microsoft Office\root\Office16\powerpoint.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + "File=\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\powerpoint.exe\"";
                        break;
                    case ".xlm":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\Program Files(x86)\Microsoft Office\root\Office16\Excel.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + "File=\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\Excel.exe\"";
                        break;
                    case ".xlsm":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\Program Files(x86)\Microsoft Office\root\Office16\Excel.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + "File=\"C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\Excel.exe\"";
                        break;
                    case ".ps1":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\windows\system32\notepad.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Windows\System32\notepad.exe";
                        break;
                    case ".mhtml":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.INTERNET_EXPLORE.getPath());
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + "File=\"" + BrowserType.INTERNET_EXPLORE.getPath() + "\"";
                        break;
                    case ".mht":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.INTERNET_EXPLORE.getPath());
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + "File=\"" + BrowserType.INTERNET_EXPLORE.getPath() + "\"";
                        break;
                    case ".hta":
                        Console.WriteLine("extension: " + extension + @" gets defaulted to: C:\windows\system32\mshta.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\windows\system32\mshta.exe";
                        break;
                    default:
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\Windows\System32\wscript.exe");
                        ftype.Arguments = "/c ftype " + extension.ToUpper() + @"File=C:\Windows\System32\wscript.exe";
                        break;
                }

                ftype.CreateNoWindow = true;
                Process proc2 = Process.Start(ftype);
                while (!proc2.HasExited) { } //lock the local thread till the process has been ended.
                proc2.Dispose();
            }
            Config.getConfig().put("renamed", false);
            getButton().Enabled = true;
            setGuiDisabled(this);
            Console.WriteLine("{== "+getType().getName().ToUpper()+" has been unapplied ==}");
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

        [Obsolete]
        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        public override bool isSafeForBussiness()
        {
            return true;
        }

        public override bool isUserControlRequired()
        {
            return false;
        }
    }
}
