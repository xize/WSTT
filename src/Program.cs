using System;
using System.Collections.Generic;
using System.Linq;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gui = new window();
            Application.Run(gui);
        }

        public static window getGui()
        {
            return gui;
        }
    }
}
