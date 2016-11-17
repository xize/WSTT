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

namespace windows_tweak_tool.src.ninite
{
    class NiniteCreator : HashSet<NiniteOption>
    {
        
        public string getNiniteURL()
        {
            string url = "https://ninite.com/";
            NiniteOption[] options = this.ToArray();
            
            for (int index = 0; index < options.Length; index++)
            {
                if(index == (options.Length-1))
                {
                    NiniteOption option = options[index];
                    url += ((NiniteOption)option).getName();
                } else
                {
                    NiniteOption option = options[index];
                    url += ((NiniteOption)option).getName()+"-";
                }
            }
            return url+"/ninite.exe";
        }

        public void downloadNiniteInstaller(string url)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.59 Safari/537.36");
            Directory.CreateDirectory(getDataFolder() + @"\ninite");
            try
            {
                client.DownloadFile(new Uri(url), getDataFolder() + @"\ninite\ninite.exe");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Unable to download ninite!, perhaps the file has been removed?\nplease visit: " + url);
                Process proc1 = Process.Start(url);
                proc1.Dispose();
                Directory.Delete(getDataFolder() + @"\ninite");
                return;
            }

            Process proc = Process.Start(getDataFolder()+@"\ninite\ninite.exe");
            
            while(!proc.HasExited)
            {
                //lock thread
            }
            proc.Dispose();
        }

        private string getDataFolder()
        {
            return Config.getConfig().getDataFolder();
        }

    }
}
