using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace windows_tweak_tool.src.policies
{
    abstract class Policy
    {

        private Dictionary<string, AutoItX3> autoit_tasks = new Dictionary<string, AutoItX3>();
        protected window gui;

        public Policy()
        {
            //initialize the embedded AutoIT dll
            hookAutoIT();
        }

        public void setGui(window win)
        {
            if(this.gui != win)
            {
                this.gui = win;
            }
        }

        public abstract bool isSecpolDepended();

        public bool isSecpolEnabled()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem")
                        .Get()
                        .OfType<ManagementObject>()
                        select x.GetPropertyValue("Caption"))
                        .FirstOrDefault();

            if(name != null)
            {
                string[] OS = name.ToString().Split(' ');
                string OS_NAME = OS[3];
                switch(OS_NAME)
                {
                    case "Pro":
                        return true;
                    case "Ultimate":
                        return true;
                    case "Professional":
                        return true;
                    default:
                        return false;
                }
            }
            return false;
        }

        public abstract bool isMacro();

        public bool isAutoItInstalled()
        {
            if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"AutoIt3\AutoItX\AutoItX3.dll") || File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"AutoIt3\AutoItX\AutoItX3.dll"))
            {
                return true;
            }
            return false;
        }

        public abstract string getName();

        public abstract PolicyType getType();

        public abstract string getDescription();

        public abstract bool isEnabled();

        public abstract void apply();

        public abstract void unapply();

        public abstract ProgressBar getProgressbar();

        public abstract Button getButton();

        protected String generateGUID()
        {
            return "{"+Guid.NewGuid().ToString()+"}";
        }

        public AutoItX3 createAutoIT(string name)
        {
            if(!autoit_tasks.ContainsKey(name.ToLower()))
            {
                AutoItX3 it = new AutoItX3();
                autoit_tasks.Add(name.ToLower(), it);
                return it;
            }
            throw new NullReferenceException("cannot add AutoIT task because this task is already active!");
        }

        public bool containsAutoITtask(string name)
        {
            if(autoit_tasks.ContainsKey(name.ToLower()))
            {
                return true;
            }
            return false;
        }

        public bool removeAutoITtask(string name)
        {
            if(containsAutoITtask(name.ToLower()))
            {
                autoit_tasks.Remove(name.ToLower());
                return true;
            }
            throw new NullReferenceException("AutoIT task does not exist, maybe the task was already removed?");
        }

        public AutoItX3 getAutoIT(string name)
        {
            if(containsAutoITtask(name))
            {
                return autoit_tasks[name.ToLower()];
            }
            throw new NullReferenceException("cannot find AutoIT task, maybe you gave in a wrong name?");
        }

        private void hookAutoIT()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };
        }
    }
}
