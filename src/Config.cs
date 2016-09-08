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
            return get<String>(node);
        }
        
        public int getInt(String node)
        {
            return get<int>(node);
        }

        public double getDouble(String node)
        {
            return get<double>(node);
        }

        public bool getBoolean(string node) {
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
            FileStream fs = File.Create("config.txt");

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
            FileStream fs = File.OpenRead("config.txt");
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

                    if (bool.Parse((string)value))
                    {
                        nodes.Add(key.ToLower(), bool.Parse((string)value));
                    } else if(double.Parse((string)value) != -1.0)
                    {
                        nodes.Add(key.ToLower(), double.Parse((string)value));
                    } else if(int.Parse((string)value) != -1)
                    {
                        nodes.Add(key.ToLower(), int.Parse((string)value));
                    }
                }
            }
            reader.Close();
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
