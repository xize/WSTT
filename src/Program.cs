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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src
{
    static class Program
    {

        private static Form gui;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
            if (Debugger.IsAttached)
            {
                CertDebugger certwindow = new CertDebugger();
                certwindow.Show();
            }
            */

            DialogResult r = MessageBox.Show("do you want to view WSTT in our new experimental gui?\n\nthe experimental gui may or may not include all functionality to the program.", "[WSTT] design question: ", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                gui = new Window2();
                Application.Run(gui);
            }
            else
            {
                gui = new Window();
                Application.Run(gui);
            }
        }

        public static Window getGui()
        {
            return (Window) gui;
        }
    }
}
