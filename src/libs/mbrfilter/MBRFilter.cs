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
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.mbrfilter
{
    class MBRFilter
    {

        private static MBRFilter filter;
        private string downloadurl = (Environment.Is64BitOperatingSystem ? "https://github.com/Cisco-Talos/MBRFilter/files/536998/64.zip" : "https://github.com/Cisco-Talos/MBRFilter/files/536997/32.zip");

        private string sha1_hash = (Environment.Is64BitOperatingSystem ?
            "1FA06368FE68B6862FE006EF2A57219123547895" : // 64-bit
            "F732E7308F1DDA5BD93038201DF7594042AA2BBA" // 32-bit
        );

        private MBRFilter(){}


        public void install()
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.59 Safari/537.36");
            Directory.CreateDirectory(Config.GetConfig().GetDataFolder() + @"\mbrfilter");
            try
            {
                client.DownloadFile(new Uri(downloadurl), Config.GetConfig().GetDataFolder() + @"\mbrfilter\mbrfilter.zip");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Unable to download  MBRFilter, perhaps the file has been removed?\nplease visit: " + downloadurl);
                Directory.Delete(Config.GetConfig().GetDataFolder() + @"\mbrfilter");
                return;
            }

            while (!validateMBRFilter(Config.GetConfig().GetDataFolder() + @"\mbrfilter\mbrfilter.zip"))
            {
                MessageBox.Show("We re-attempt to download MBRFilter again\nit would be wise to check your connection against manipulation", "invalid or tampered version of MBRFilter downloaded!");
                File.Delete(Config.GetConfig().GetDataFolder() + @"\mbrfilter\mbrfilter.zip");
                client.DownloadFile(new Uri(downloadurl), Config.GetConfig().GetDataFolder() + @"\mbrfilter\mbrfilter.zip");
            }

            ZipArchive archive = ZipFile.OpenRead(Config.GetConfig().GetDataFolder() + @"\mbrfilter\mbrfilter.zip");
            archive.ExtractToDirectory(Config.GetConfig().GetDataFolder() + @"\mbrfilter");
            archive.Dispose();
            File.Delete(Config.GetConfig().GetDataFolder() + @"\mbrfilter\mbrfilter.zip");

            ProcessStartInfo proci = new ProcessStartInfo("infdefaultinstall.exe");
            proci.Arguments = "\"" + Config.GetConfig().GetDataFolder() + @"\mbrfilter\" + (Environment.Is64BitOperatingSystem ? "64" : "32") + @"\MBRFilter.inf" + "\"";
            Process proc = Process.Start(proci);
            proc.WaitForExit();
            proc.Dispose();
        }

        public void uninstall()
        {
            RegistryKey classes = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"System\CurrentControlSet\Control\Class\{4d36e967-e325-11ce-bfc1-08002be10318}\", true);
            List<String> orginal = new List<string>((string[])classes.GetValue("UpperFilters"));
            orginal.Remove("MBRFilter");
            classes.SetValue("UpperFilters", orginal.ToArray());

            foreach (string a in Directory.GetFiles(Config.GetConfig().GetDataFolder() + @"\mbrfilter"))
            {
                File.Delete(a);
            }
            Directory.Delete(Config.GetConfig().GetDataFolder() + @"\mbrfilter", true);
        }

        public bool isInstalled()
        {
            try
            {
                RegistryKey classes = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"System\CurrentControlSet\Control\Class\{4d36e967-e325-11ce-bfc1-08002be10318}");
                List<String> data = new List<string>((String[]) classes.GetValue("UpperFilters"));
                return data.Contains("MBRFilter");
            }
            catch (Exception){ return false; }
        }

        private bool validateMBRFilter(string file)
        {
            byte[] bhash = SHA1.Create().ComputeHash(File.ReadAllBytes(file));
            StringBuilder hash = new StringBuilder();
            for(int i = 0; i < bhash.Length;i++)
            {
                hash.Append(bhash[i].ToString("X2"));
            }

            return hash.ToString() == sha1_hash;
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
