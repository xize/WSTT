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

        [Override]
        public String getString(String node)
        {
            return get<String>(node);
        }
        
        [Override]
        public int getInt(String node)
        {
            return get<int>(node);
        }

        [Override]
        public double getDouble(String node)
        {
            return get<double>(node);
        }

        [Override]
        public bool getBoolean(string node) {
            return get<bool>(node);
        }

        [Override]
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
            obj = nodes.TryGetValue(node.ToLower(), out obj);
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

        private void readConfig()
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
                    object value = node.Split(':')[1];

                    //set the object to a string since it is a primitive, then check for the real primitive:
                    string v = (string)value;

                    Console.WriteLine("value: "+v);

                    if (v.ToLower() == "true" || v.ToLower() == "false")
                    {
                        //the primitive is a boolean so we set the type to a instanceof boolean.

                        value = Boolean.Parse(v);
                        
                    } else {
                        //the type is either a instanceof int or double
                        if (Regex.IsMatch(v, "^[0-9]+$"))
                        {
                            value = (int)value;
                        }
                        else if (Regex.IsMatch(v, "^[0-9\\.]+$"))
                        {
                            value = (double)value;
                        }
                    }
                    //add the key and the fixed value to the map, already existed keys will be updated. 
                    if(nodes.ContainsKey(key))
                    {
                        nodes.Remove(key);
                    }
                    nodes.Add(key.ToLower(), value);
                }
            }
            reader.Close();
        }


        public static ConfigInfo getConfig()
        {
            if(cfg == null)
            {
                cfg = new Config();
            }
            return cfg;
        }

    }
}
