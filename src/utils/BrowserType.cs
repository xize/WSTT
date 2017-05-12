/*
    A security toolkit for windows    

    Copyright(C) 2017 Guido Lucassen

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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.utils
{
    class BrowserType
    {

        private static HashSet<BrowserType> data = new HashSet<BrowserType>();

        public static BrowserType INTERNET_EXPLORE = new BrowserType("IE.HTTP", (Environment.Is64BitOperatingSystem ? @"C:\Program Files\Internet Explorer\iexplore.exe" : @"C:\Program Files (x86)\Internet Explorer\iexplore.exe"));
        public static BrowserType FIREFOX = new BrowserType("FirefoxURL", (Environment.Is64BitOperatingSystem ? @"C:\Program Files\Mozilla Firefox\firefox.exe" : @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe"));
        public static BrowserType CHROME = new BrowserType("ChromeHTML", (Environment.Is64BitOperatingSystem ? @"C:\Program Files\Google\Chrome\Application\chrome.exe" : @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"));
        public static BrowserType UNKNOWN = new BrowserType("Unknown", null);
        //public static BrowserType DEFAULT_BROWSER = (Browser.getBrowser().getCurrentBrowserType() != BrowserType.UNKOWN ? Browser.getBrowser().getCurrentBrowserType() : BrowserType.INTERNET_EXPLORE);

        private string name;
        private string path;

        private BrowserType(string name, string path)
        {
            this.name = name;
            this.path = path;
            data.Add(this);
        }

        public string getName()
        {
            return name;
        }

        public string getPath()
        {
            if(!File.Exists(path) && Environment.Is64BitOperatingSystem)
            {
                return @"C:\Program Files (x86)\" + path.Substring(@"C:\Program Files\".Length);
            }
            return path;
        }

        public static BrowserType[] values()
        {
            return data.ToArray();
        }

        public static BrowserType valueOf(string name)
        {
            foreach(BrowserType type in values())
            {
                if(name.ToLower().StartsWith(type.getName().ToLower()))
                {
                    return type;
                }
            }
            return BrowserType.UNKNOWN;
        }

    }
}
