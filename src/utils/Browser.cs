using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.utils
{
    class Browser
    {

        private static Browser brow;

        private Browser() {}

        public BrowserType getCurrentBrowserType()
        {
            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, (Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32)).OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice");
            if(key == null)
            {
                return BrowserType.UNKOWN;
            }

            object progID = key.GetValue("Progid");
            if(progID == null)
            {
                return BrowserType.UNKOWN;
            }

            return BrowserType.valueOf(progID.ToString()); ;
        }

        public static Browser getBrowser()
        {
            if(brow == null)
            {
                brow = new Browser();
            }
            return brow;
        }

    }
}
