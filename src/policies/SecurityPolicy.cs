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
using windows_security_tweak_tool.src.policies.components;
using System.Diagnostics;
using windows_security_tweak_tool.src.utils;
using windows_security_tweak_tool.src.certificates;
using System.Net;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace windows_security_tweak_tool.src.policies
{
    abstract class SecurityPolicy : Services
    {
        private int version = -1;

        protected Window gui;

        //don't instance the class :)
        protected SecurityPolicy() { }

        /**
        * <summary>
        *      <para>sets the gui for the first time</para>
        * </summary>
        **/
        public void SetGui(Window win)
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
        public void SetGuiEnabled(SecurityPolicy p)
        {
            p.GetProgressbar().Value = 100;
            p.GetButton().Text = "Undo";
        }

        /**
        * <summary>
        *      <para>sets the progress to 0% and the button to apply.</para>
        * </summary>
        **/
        public void SetGuiDisabled(SecurityPolicy p)
        {
            p.GetProgressbar().Value = 0;
            p.GetButton().Text = "Apply";
        }

        /**
        * <summary>
        *      <para>sets the progress to full and the button to unapply</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool IsUserControlRequired();

        /**
        * <summary>
        *      <para>returns true if the policy is secpol depended or not</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool IsSecpolDepended();

        /**
        * <summary>
        *      <para>returns true whenever secpol is enabled on the system!</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public bool IsSecpolEnabled()
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

        public void DownloadSigCheck()
        {
            string url = "https://download.sysinternals.com/files/Sigcheck.zip";
            bool isverified = false;
            bool isfirst = false;

            if (!Directory.Exists(GetDataFolder() + @"\sigcheck"))
            {
                Directory.CreateDirectory(GetDataFolder() + @"\sigcheck");
                isfirst = true;
            }

            DateTime time = Directory.GetLastWriteTime(GetDataFolder() + @"\sigcheck\");
            DateTime expire = time.AddMonths(1);

            if (!isfirst && (expire.Ticks-time.Ticks) > 0)
            {
                //prevents to update sigcheck everytime, just update once per month!
                return;
            }


            while (!isverified)
            {
                WebClient client = new WebClient();
                
                foreach (string f in Directory.EnumerateFiles(GetDataFolder() + @"\sigcheck\", "*.*"))
                {
                    File.Delete(f);
                }

                client.DownloadFile(url, GetDataFolder() + @"\sigcheck\sigcheck.zip");
                client.Dispose();
                ZipArchive zip = new ZipArchive(File.OpenRead(GetDataFolder() + @"\sigcheck\sigcheck.zip"));
                zip.ExtractToDirectory(GetDataFolder() + @"\sigcheck");
                zip.Dispose();

                //verify files by hand from the hashes from the signed certificate!
                bool isbad = false;
                foreach (string exe in Directory.EnumerateFiles(GetDataFolder() + @"\sigcheck\", " *.exe"))
                {
                    string hash = X509Certificate.CreateFromSignedFile(exe).GetCertHashString();
                    if (hash != CertProvider.SIGCHECK_32BIT.GetCertificate().GetHash() || hash != CertProvider.SIGCHECK_64BIT.GetCertificate().GetHash())
                    {
                        isbad = true;
                        break;
                    }
                }
                if (!isbad)
                {
                    isverified = true;
                }
                else
                {
                    MessageBox.Show("a corrupted version of sigcheck has been downloaded, we redownload this version again!", "invalid version of SigCheck redownloading certificate mismatch...");
                }
            }
        }

        /**
        * <summary>
        *      <para>returns true if this policy is macro depended</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool IsMacro();

        /**
        * <summary>
        *      <para>returns true if this policy can be used in environments without breaking the domain controller</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool IsSafeForBussiness();

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
        public abstract bool IsLanguageDepended();

        /**
        * <summary>
        *      <para>returns true if the said policy has incompatibility issues between different versions of the OS</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool HasIncompatibilityIssues();

        /**
        * <summary>
        *      <para>returns the name of this policy</para>
        * </summary>
        * <returns>string</returns>
        **/
        public abstract string GetName();

        /**
        * <summary>
        *      <para>returns the PolicyType  of this policy</para>
        * </summary>
        * <returns>PolicyType</returns>
        **/
        public abstract SecurityPolicyType GetPolicyType();

        /**
        * <summary>
        *      <para>returns the description of this policy</para>
        * </summary>
        * <returns>string</returns>
        **/
        public abstract string GetDescription();

        /**
        * <summary>
        *      <para>returns true if this policy is enabled otherwise false</para>
        * </summary>
        * <returns>bool</returns>
        **/
        public abstract bool IsEnabled();

        public virtual bool isAsync()
        {
            return (IsMacro() ? false : true);
        }

        /**
         * <summary>
         *      <para>returns true if the policy is certificate dependend</para>
         * </summary>
         * <returns>bool</returns>
         * */
        public abstract bool IsCertificateDepended();

        /**
         * <summary>
         *      <para>returns the certificate</para>
         * </summary>
         * <returns>Certificate</returns>
         * */
        public abstract Certificate GetCertificate();

        /**
        * <summary>
        *      <para>applies the policy</para>
        * </summary>
        **/
        public abstract void Apply();

        /**
        * <summary>
        *      <para>unapplies the policy</para>
        * </summary>
        **/
        public abstract void Unapply();

        /**
        * <summary>
        *      <para>returns the progress bar from the policy</para>
        * </summary>
        * <returns>ProgressBar</returns>
        **/
        public abstract ProgressBar GetProgressbar();

        /**
        * <summary>
        *      <para>returns the button from the policy</para>
        * </summary>
        * <returns>Button</returns>
        **/
        public abstract Button GetButton();

        /**
        * <summary>
        *      <para>returns the installation directory</para>
        * </summary>
        * <returns>string</returns>
        **/
        public string GetDataFolder()
        {
            return Config.GetConfig().GetDataFolder();
        }

        /**
        * <summary>
        *      <para>returns the version id of windows</para>
        * </summary>
        * <returns>int</returns>
        **/
        public int GetWindowsVersion()
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

        public BrowserType GetBrowser()
        {
            return Browser.getBrowser().getCurrentBrowserType();
        }

    }
}
