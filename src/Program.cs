using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src
{
    static class Program
    {

        private static window gui;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(isElevated())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                gui = new window();
                Application.Run(gui);
            } else
            {
                RunElevated(Application.ExecutablePath);
            }
        }

        public static window getGui()
        {
            return gui;
        }

        public static bool isElevated()
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if(pricipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                return true;
            }
            return false;
        }

        private static void RunElevated(string fileName)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.Verb = "runas";
            processInfo.FileName = fileName;
            try
            {
                Process.Start(processInfo);
            }
            catch (Win32Exception)
            {
                //Do nothing. Probably the user canceled the UAC window
            }
        }
    }
}
