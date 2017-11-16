using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windows_security_tweak_tool.src.policies;

namespace windows_security_tweak_tool.src.socket.client
{
    interface WindowsClient
    {
        /**
         * <summary>connect the client to an server</summary>
         * */
        void Connect(string ip);

        /**
         *  <summary>disconnect the client</summary>
         * */
        void Disconnect();

        /**
         * <summary>returns true when the client is connected or disconnected</summary>
         * */
        bool IsConnected();

        /**
         * <summary>gets the ip address of the client</summary>
         * */
        string GetIPAddress();

        /**
         * <summary>applies a policy</summary>
         * */
        void ApplyPolicy(SecurityPolicy p);

        /**
         * <summary>unapplies a policy</summary>
         * */
        void UnApplyPolicy(SecurityPolicy p);

        /**
         * <summary>checks if a certain policy is enabled</summary>
         * */
        bool IsPolicyEnabled(SecurityPolicy p);

        /**
         * <summary>gets all security policies owned by this client</summary>
         * */
        SecurityPolicy[] GetClientSecurityPolicies();

        /**
         * <summary>gets the host, this is being used for verification</summary>
         * */
        string GetHost();

        /**
         * <summary>gets the handshake given by the server, if this handshake is different we will throw a Checksum exception</summary>
         * */
        string GetMatchingHandShake();

    }
}
