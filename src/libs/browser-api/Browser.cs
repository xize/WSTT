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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src.utils
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
                return BrowserType.UNKNOWN;
            }

            object progID = key.GetValue("Progid");
            if(progID == null)
            {
                return BrowserType.UNKNOWN;
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
