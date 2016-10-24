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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace windows_tweak_tool.src
{
    class Config : ConfigInfo
    {

        private static Config cfg;

        private Dictionary<String, Object> nodes = new Dictionary<String, Object>();

        private Config() { }

        public String getString(String node)
        {
            if(!nodes.ContainsKey(node.ToLower()))
            {
                return null;
            }
            return get<String>(node);
        }
        
        public int getInt(String node)
        {
            if(!nodes.ContainsKey((node.ToLower())))
            {
                return 0;
            }
            return get<int>(node);
        }

        public double getDouble(String node)
        {
            if(!nodes.ContainsKey(node.ToLower()))
            {
                return 0.0;
            }
            return get<double>(node);
        }

        public bool getBoolean(string node) {
            if(!nodes.ContainsKey(node.ToLower()))
            {
                return false;
            }
            return get<bool>(node);
        }

        public void put(String node, Object obj)
        {
            if(!nodes.ContainsKey(node.ToLower()))
            {
                nodes.Add(node.ToLower(), obj);
            } else
            {
                nodes.Remove(node.ToLower());
                nodes.Add(node.ToLower(), obj);
            }
            reloadConfig();
        }

        public void reloadConfig()
        {
            saveConfig();
            readConfig();
        }

        private T get<T>(string node)
        {
            Object obj = null;
            obj = nodes[node.ToLower()];
            return (T)obj;
        }

        private void saveConfig()
        {

            string path = getDataFolder();

            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            FileStream fs = File.Create(path+@"\config.txt");

            string data = "";

            foreach (KeyValuePair<String, Object> set in nodes)
            {
                data += set.Key + ": " + set.Value+"\r\n";
            }

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
            fs.Close();
        }

        public void readConfig()
        {

            string path = getDataFolder();

            if (!Directory.Exists(path))
            {
                return;
            }

            if (!File.Exists(path+@"\config.txt"))
            {
                return;
            }
            FileStream fs = File.OpenRead(path+@"\config.txt");
            StreamReader reader = new StreamReader(fs);
            string cfg = reader.ReadToEnd();
            string[] cfglines = cfg.Split('\n');
            for (int index = 0; index < cfglines.Length; index++)
            {
                String node = cfglines[index];
                if(node.Contains(":"))
                {
                    node = node.Replace(" ", "");
                    node = node.Replace("\r", "");
                    node = node.Replace("\n", "");

                    string key = node.Split(':')[0];
                    Object value = (Object)node.Split(':')[1];

                    //add the key and the fixed value to the map, already existed keys will be updated. 
                    if (nodes.ContainsKey(key))
                    {
                        nodes.Remove(key);
                    }

                    bool bol = false;
                    double dresult = 0.0;
                    int iresult = 0;

                    if (bool.TryParse((string)value, out bol))
                    {
                        nodes.Add(key.ToLower(), bool.Parse((string)value));
                    } else if(((string)value).Contains(".") && double.TryParse((string)value, out dresult))
                    {
                        nodes.Add(key.ToLower(), dresult);
                    } else if(int.TryParse((string)value, out iresult))
                    {
                        nodes.Add(key.ToLower(), iresult);
                    }
                }
            }
            reader.Close();
        }

        public string getDataFolder()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if(Directory.Exists(appdata+@"\WSTT"))
            {
                return appdata + @"\WSTT";
            } else if(Directory.Exists(appdata+@"\WTT"))
            {
                Directory.Move(appdata+@"\WTT", appdata + @"\WSTT");
            } else
            {
                string path = appdata + @"\WSTT";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                FileStream fs = File.Create(path + @"\config.txt");

                string data = "";

                foreach (KeyValuePair<String, Object> set in nodes)
                {
                    data += set.Key + ": " + set.Value + "\r\n";
                }

                byte[] bytes = Encoding.UTF8.GetBytes(data);
                fs.Write(bytes, 0, bytes.Length);
                fs.Flush();
                fs.Close();
            }

            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\WSTT";
        }


        public static Config getConfig()
        {
            if(cfg == null)
            {
                cfg = new Config();
            }
            return cfg;
        }

    }
}
