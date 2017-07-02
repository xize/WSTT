using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.mbrfilter
{
    class MBRFilter
    {

        private static MBRFilter filter;
        private string downloadurl = (Environment.Is64BitOperatingSystem ? "https://github.com/Cisco-Talos/MBRFilter/files/536998/64.zip" : "https://github.com/Cisco-Talos/MBRFilter/files/536997/32.zip");

        private MBRFilter(){}


        public void install()
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.59 Safari/537.36");
            Directory.CreateDirectory(Config.getConfig().getDataFolder() + @"\mbrfilter");
            try
            {
                client.DownloadFile(new Uri(downloadurl), Config.getConfig().getDataFolder() + @"\mbrfilter\mbrfilter.zip");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Unable to download  MBRFilter, perhaps the file has been removed?\nplease visit: " + downloadurl);
                Directory.Delete(Config.getConfig().getDataFolder() + @"\mbrfilter");
                return;
            }
            ZipArchive archive = ZipFile.OpenRead(Config.getConfig().getDataFolder() + @"\mbrfilter\mbrfilter.zip");
            archive.ExtractToDirectory(Config.getConfig().getDataFolder() + @"\mbrfilter");
            archive.Dispose();
            File.Delete(Config.getConfig().getDataFolder() + @"\mbrfilter\mbrfilter.zip");

            ProcessStartInfo proci = new ProcessStartInfo("infdefaultinstall.exe");
            proci.Arguments = "\"" + Config.getConfig().getDataFolder() + @"\mbrfilter\" + (Environment.Is64BitOperatingSystem ? "64" : "32") + @"\MBRFilter.inf" + "\"";
            Process proc = Process.Start(proci);
            proc.WaitForExit();
            proc.Dispose();
        }

        public void uninstall()
        {
            RegistryKey classes = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"HKLM\System\CurrentControlSet\Control\Class\{4d36e967-e325-11ce-bfc1-08002be10318}");
            classes.DeleteSubKey("{4d36e967-e325-11ce-bfc1-08002be10318}");

            foreach (string a in Directory.GetFiles(Config.getConfig().getDataFolder() + @"\mbrfilter"))
            {
                File.Delete(a);
            }
            Directory.Delete(Config.getConfig().getDataFolder() + @"\mbrfilter", true);
        }

        public bool isInstalled()
        {
            try
            {
                RegistryKey classes = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"HKLM\System\CurrentControlSet\Control\Class\{4d36e967-e325-11ce-bfc1-08002be10318}");
                if (classes != null)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (Exception){ return false; }
        }

        public static MBRFilter getMBRFilter()
        {
            if(filter == null)
            {
                filter = new MBRFilter();
            }
            return filter;
        }


    }
}
