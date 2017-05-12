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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src.policies.components
{
   abstract class Registry
    {
        /**
        * <summary>
        *      <para>gets the registry key by name</para>
        *      <para></para>
        * </summary>
        * <returns>RegistryKey</returns>
        **/
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
            }
            else
            {
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

        /**
        * <summary>
        *      <para>returns the REG enum type</para>
        *      <para></para>
        * </summary>
        * <returns>enum</returns>
        **/
        public enum REG
        {
            HKLM,
            HKCU,
            HKCR
        }

    }
}
