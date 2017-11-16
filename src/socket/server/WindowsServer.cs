using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windows_security_tweak_tool.src.socket.client;

namespace windows_security_tweak_tool.src.socket.server
{
    interface WindowsServer
    {

        /**
         * <summary>starts the server</summary>
         * */
        void Start();

        /**
         * <summary>stops the server</summary>
         * */
        void Stop();

        /**
         * <summary>checks if the server is running</summary>
         * */
        bool IsRunning();

        /**
         * <summary>gets the secret generated handshake, this needs to be matched to clients if it doesn't disconnect.</summary>
         * */
        string GetHandshakeChecksum();

        /**
         * <summary>gets all the clients which match with the current handshake</summary>
         * */
        WindowsClient[] GetClients();

    }
}
