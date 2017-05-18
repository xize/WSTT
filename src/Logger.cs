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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src
{
    class Logger
    {
        private static SubTreeLogger subtree;
        private static LogoLogger logo;

        public static void log(string msg)
        {
            Console.WriteLine(msg);
        }

        public static SubTreeLogger getSubTreeLogger()
        {
            if(subtree == null)
            {
                subtree = new SubTreeLogger();
            }
            return subtree;
        }

        public static LogoLogger getLogoLogger()
        {
            if(logo == null)
            {
                logo = new LogoLogger();
            }
            return logo;
        }
    }

    class LogoLogger
    {
        public void ShowLogo()
        {
            writeBar();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" __      __  _______________________________");
            Console.WriteLine(@"/  \    /  \/   _____/\__    ___/\__    ___/");
            Console.WriteLine(@"\   \/\/   /\_____  \   |    |     |    |   ");
            Console.WriteLine(@" \        / /        \  |    |     |    |   ");
            Console.WriteLine(@"  \__/\  / /_______  /  |____|     |____|   ");
            Console.WriteLine(@"       \/          \/                       ");
            writeBar();
            Console.WriteLine("    © WSTT All rights reserved 2016-2017    ");
            Console.WriteLine("      Program is licensed under GPLv3       ");
            writeBar();
        }

        private void writeBar()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("==========================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("+\n");
        }
    }

    class SubTreeLogger
    {
        public void LogTitle(string data)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(data + "\n");
        }

        public void LogTree(string data)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   [»] ");
            Console.ResetColor();
            Console.Write(data + "\n");
        }

        public void LogTreeEnd(string data)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[+] ");
            Console.ResetColor();
            Console.Write(data + "\n");
        }
    }
}
