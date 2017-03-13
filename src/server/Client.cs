using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.server
{
    class Client
    {

        private string ip;
        private Socket c;

        public Client(Socket c)
        {
            string ip = ((IPEndPoint)c.LocalEndPoint).Address.ToString();
            if (validateLocal(ip))
            {
                this.ip = ip;
                this.c = c;
            } else
            {
                c.Disconnect(false);
                c.Dispose();
                throw new Exception("IP: "+ip+" is either invalid, or not following the local ip address subnet!");
            }
        }

        public string getIP()
        {
            return ip;
        }

        public void disconnect()
        {

        }

        public void connect()
        {

        }

        private bool validateLocal(string ip)
        {
            //follow the RFC1918 rules because we only want to allow local ip addresses over the lan network.
            //this regex will be used to blackhole any other external addresses.
            Regex r = new Regex(@"(^192\.168\.[0-254]\.[1-254])|(^10\.[0-254]\.[0-254]\.[1-254])|(^172\.16\.[0-254]\.[1-254])");
            if (r.IsMatch(ip))
            {
                return true;
            }
            return false;
        }

    }
}
