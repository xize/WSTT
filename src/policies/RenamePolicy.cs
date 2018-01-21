/*
    A security toolkit for windows    

    Copyright(C) 2016-2017 Guido Lucassen

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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;
using windows_security_tweak_tool.src.utils;

namespace windows_security_tweak_tool.src.policies
{
    class RenamePolicy : SecurityPolicy
    {

        private string[] extensions =
        {
            //scripts, however there are alot more but I lost the article....
            ".js",
            ".svg",
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
            //html and help components
            ".mhtml",
            ".mht",
            ".hta",
            ".cfm",
            //special cases...
            ".pdf", //because it is vulnerable
            ".tif",
            ".tiff" //Tempory disable Tiff remote explotation, see: https://threatpost.com/remote-code-execution-vulnerabilities-plague-libtiff-library/121570/ not sure if this is the correct way of megitation!
        };

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "renames the default program for the following extensions:\n"+string.Join(",", extensions)+"\n\nthis megitates code what can be load from javascript as a vbs script, this also disables macros";
        }


        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.RENAME_POLICY;
        }

        public override bool IsEnabled()
        {
            if(Config.GetConfig().GetBoolean("renamed"))
            {
                return true;
            }
            return false;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            //ApplyAsync();

            SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {

            StringBuilder build = new StringBuilder();

            foreach (string extension in extensions)
            {
                //ExecuteCMD("assoc " + extension + "=txtfile", false);
                build.Append("ftype " + extension.ToUpper().Substring(1) + "File=C:\\windows\\system32\\notepad.exe && ");
            }

            build.Append("echo done!");

            ExecuteCMD(build.ToString(), true);

            Config.GetConfig().Put("renamed", true);
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => UnapplyAsync());

            GetButton().Enabled = true;
            SetGuiDisabled(this);
        }

        public void UnapplyAsync()
        {

            BrowserType type = this.GetBrowser();

            string officepath = null;
            char[] disks = {'b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            foreach(char disk in disks) {
                if(Directory.Exists(disk+@":\Program Files (x86)\Microsoft Office\root"))
                {
                    officepath = Directory.EnumerateDirectories(disk + @":\Program Files (x86)\Microsoft Office\root\").First();
                }
            }

            StringBuilder build = new StringBuilder();

            foreach (string extension in extensions)
            {
                //ExecuteCMD("assoc " + extension + " = " + extension.ToUpper() + "File", true);

                string argument = "";

                switch (extension)
                {
                    //TODO: figuring out how these macros work..... which program it uses to be exact.
                    //http://filext.com/file-extension/DOCM good site to check the default locations for. <- this list is not done yet!
                    case ".docm":
                        if (officepath != null)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + officepath + "\\winword.exe");
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\""+officepath+ "\\winword.exe /n\" && ";
                        }
                        break;
                    case ".dotm":
                        if(officepath != null)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + officepath +"\\winword.exe");
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\""+officepath+ "\\winword.exe /n\" && ";
                        }
                        break;
                    case ".pptm":
                        if(officepath != null)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + officepath+"\\powerpoint.exe");
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\""+officepath+ "\\powerpoint.exe /n\" && ";
                        }
                        break;
                    case ".xlm":
                        if(officepath != null)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + officepath +"\\Excel.exe");
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\""+officepath+ "\\Excel.exe /n\" && ";
                        }
                        break;
                    case ".xlsm":
                        if (officepath != null)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + officepath + "\\Excel.exe");
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\""+ officepath + "\\Excel.exe/n\" && ";
                        }
                        break;
                    case ".ps1":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\windows\system32\notepad.exe");
                        argument = "ftype " + extension.Substring(1).ToUpper() + @"File=C:\Windows\System32\notepad.exe && ";
                        break;
                    case ".mhtml":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.INTERNET_EXPLORE.getPath());
                        argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.INTERNET_EXPLORE.getPath() + "\" && ";
                        break;
                    case ".mht":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.INTERNET_EXPLORE.getPath());
                        argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.INTERNET_EXPLORE.getPath() + "\" && ";
                        break;
                    case ".hta":
                        Console.WriteLine("extension: " + extension + @" gets defaulted to: C:\windows\system32\mshta.exe");
                        argument = "ftype " + extension.Substring(1).ToUpper() + @"File=C:\windows\system32\mshta.exe && ";
                        break;
                    case ".svg":
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.INTERNET_EXPLORE.getPath());
                        argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.INTERNET_EXPLORE.getPath() + "\" && ";
                        break;
                    case ".pdf":
                        if (type == BrowserType.CHROME)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.CHROME.getPath());
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.CHROME.getPath() + "\" && ";
                        }
                        else if (type == BrowserType.FIREFOX)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.FIREFOX.getPath());
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.FIREFOX.getPath() + "\" && ";
                        }
                        else
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.INTERNET_EXPLORE.getPath());
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.INTERNET_EXPLORE.getPath() + "\" && ";
                        }
                        break;
                    case ".cfm":
                        if (type == BrowserType.CHROME)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.CHROME.getPath());
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.CHROME.getPath() + "\" && ";
                        }
                        else if (type == BrowserType.FIREFOX)
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.FIREFOX.getPath());
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.FIREFOX.getPath() + "\" && ";
                        }
                        else
                        {
                            Console.WriteLine("extension: " + extension + " gets defaulted to: " + BrowserType.INTERNET_EXPLORE.getPath());
                            argument = "ftype " + extension.Substring(1).ToUpper() + "File=\"" + BrowserType.INTERNET_EXPLORE.getPath() + "\" && ";
                        }
                        break;
                    default:
                        Console.WriteLine("extension: " + extension + " gets defaulted to: " + @"C:\Windows\System32\wscript.exe");
                        argument = "ftype " + extension.Substring(1).ToUpper() + @"File=C:\Windows\System32\wscript.exe && ";
                        break;
                }

                build.Append(argument);
            }

            build.Append("echo done!");

            ExecuteCMD(build.ToString(), true);
            Config.GetConfig().Put("renamed", false);
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override Button GetButton()
        {
            return gui.renamebtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.renameprogress;
        }

        public override bool IsCertificateDepended()
        {
            return false;
        }

        public override Certificate GetCertificate()
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return false;
        }

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        public override bool IsSafeForBussiness()
        {
            return true;
        }

        public override bool IsUserControlRequired()
        {
            return false;
        }
    }
}
