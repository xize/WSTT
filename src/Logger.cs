using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src
{
    class Logger
    {

        public static void logTitle(string data)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[+] ");
            Console.ResetColor();
            Console.Write(data+"\n");
        }

        public static void LogTree(string data)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("   [»] ");
            Console.ResetColor();
            Console.Write(data+"\n");
        }

        public static void LogTreeEnd(string data)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[+] ");
            Console.ResetColor();
            Console.Write(data + "\n");
        }
    }
}
