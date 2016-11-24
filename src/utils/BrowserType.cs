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
        public static BrowserType UNKOWN = new BrowserType("Unknown", null);

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
                //fix issues with google to be 32bit even when the 64bit version is installed...
                return @"C:\Program Files (X86)"+path.Substring(@"C:\Program Files".Length, path.Length);
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
            return BrowserType.UNKOWN;
        }

    }
}
