﻿/*
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.ServiceProcess;
using AutoIt;
using windows_tweak_tool.src.policies.components;

namespace windows_tweak_tool.src.policies
{
    abstract class Policy : Services
    {
        private int version = -1;
        protected window gui;

        protected Policy(){} //don't instance the class :)

        /**
        * <summary>
        *      <para>sets the gui for the first time</para>
        * </summary>
        **/
        public void setGui(window win)
        {
            if(this.gui != win)
            {
                this.gui = win;
            }
        }

        /**
        * <summary>
        *      <para>sets the progress to 100% and the button to unapply.</para>
        * </summary>
        **/
        public void setGuiEnabled(Policy p)
        {
            p.getProgressbar().Value = 100;
            p.getButton().Text = "Undo";
        }

        /**
        * <summary>
        *      <para>sets the progress to 0% and the button to apply.</para>
        * </summary>
        **/
        public void setGuiDisabled(Policy p)
        {
            p.getProgressbar().Value = 0;
            p.getButton().Text = "Apply";
        }

        /**
        * <summary>
        *      <para>sets the progress to full and the button to unapply</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool isUserControlRequired();

        /**
        * <summary>
        *      <para>returns true if the policy is secpol depended or not</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool isSecpolDepended();

        /**
        * <summary>
        *      <para>returns true whenever secpol is enabled on the system!</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public bool isSecpolEnabled()
        {
                ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
                var name = (from x in search.Get().OfType<ManagementObject>() select x.GetPropertyValue("Caption")).FirstOrDefault();
                search.Dispose();

                if (name != null)
                {
                    string[] OS = name.ToString().Split(' ');
                    string OS_NAME = OS[3];
                    switch (OS_NAME)
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
        
        /**
        * <summary>
        *      <para>returns true if this policy is macro depended</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool isMacro();

        /**
        * <summary>
        *      <para>returns true if this policy can be used in environments without breaking the domain controller</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool isSafeForBussiness();

        /**
         * <summary>
         *      <para>this method has been deprecated, since we are not sure if we can make AutoIT macros language independed, this method will be a fallback.</para>
         *      <para></para>
         *      <para>returns true if the policy is language depended otherwise false.</para>
         * </summary>
         *
         * <returns>bool</returns>
         * */
        [Obsolete]
        public abstract bool isLanguageDepended();

        /**
        * <summary>
        *      <para>returns true if the said policy has incompatibility issues between different versions of the OS</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool hasIncompatibilityIssues();

        /**
        * <summary>
        *      <para>returns the name of this policy</para>
        * </summary>
        * <returns>string</returns>
        **/
        public abstract string getName();

        public abstract PolicyType getType();

        public abstract string getDescription();

        public abstract bool isEnabled();

        public abstract void apply();

        public abstract void unapply();

        public abstract ProgressBar getProgressbar();

        public abstract Button getButton();

        public string getDataFolder()
        {
            return Config.getConfig().getDataFolder();
        }

        private int getWindowsVersion()
        {
            if (version > -1)
            {
                return version;
            }
            else
            {
                ManagementObjectSearcher search = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
                var name = (from x in search.Get().OfType<ManagementObject>() select x.GetPropertyValue("Caption")).FirstOrDefault();
                search.Dispose();

                if (name != null)
                {
                    string[] OS = name.ToString().Split(' ');
                    return Convert.ToInt32(OS[2]);
                }
            }
            throw new Exception("Failed to get Windows version, maybe WMI is broken?");
        }
    }
}
