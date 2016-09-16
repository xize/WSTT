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
using Microsoft.Win32;

namespace windows_tweak_tool.src.policies
{
    abstract class Policy
    {

        private Dictionary<string, AutoItX3> autoit_tasks = new Dictionary<string, AutoItX3>();
        protected window gui;

        protected Policy()
        {
            
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

            string b32 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"/AutoIt3\AutoItX\AutoItX3.dll";
            string b64 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"/AutoIt3\AutoItX\AutoItX3.dll";

            if (File.Exists(b32) || File.Exists(b64))
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

        public RegistryKey getRegistry(string path, REG reg)
        {
            if (path == null)
            {
                switch (reg)
                {
                    case REG.HKCR:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry32));
                    case REG.HKCU:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32));
                    case REG.HKLM:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32));
                    default:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32));
                }
            } else {
                switch (reg)
                {
                    case REG.HKCR:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry32)).OpenSubKey(path, true);
                    case REG.HKCU:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32)).OpenSubKey(path, true);
                    case REG.HKLM:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32)).OpenSubKey(path, true);
                    default:
                        return (Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64) : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32)).OpenSubKey(path, true);
                }
            }
        }

       public enum REG
        {
            HKLM,
            HKCU,
            HKCR
        }
    }
}
