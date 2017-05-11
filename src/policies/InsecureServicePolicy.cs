using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class InsecureServicePolicy : SecurityPolicy
    {

        private Dictionary<string, ServiceType> badservices = new Dictionary<string, ServiceType>();

        public InsecureServicePolicy()
        {
			//TODO: http://hardenwindows8forsecurity.com/Harden%20Windows%208.1%2064bit%20Home.html
            //add standard vanilla values.
            badservices.Add("AJRouter", ServiceType.MANUAL);
            badservices.Add("ALG", ServiceType.MANUAL);
            badservices.Add("AppXSvc", ServiceType.MANUAL);
            badservices.Add("BthHFSrv", ServiceType.MANUAL);
            badservices.Add("bthserv", ServiceType.MANUAL);
            badservices.Add("PeerDistSvc", ServiceType.MANUAL);
            badservices.Add("ClipSVC", ServiceType.MANUAL);
            badservices.Add("Browser", ServiceType.MANUAL);
            badservices.Add("DiagTrack", ServiceType.AUTOMATIC);
            badservices.Add("PimIndexMaintenanceSvc_7d87e", ServiceType.MANUAL);
            badservices.Add("DsSvc", ServiceType.MANUAL);
            badservices.Add("DcpSvc", ServiceType.MANUAL);
            badservices.Add("DoSvc", ServiceType.AUTOMATIC_SLOWED);
            badservices.Add("dmwappushservice", ServiceType.MANUAL);
            badservices.Add("Dnscache", ServiceType.AUTOMATIC);
            badservices.Add("MapsBroker", ServiceType.AUTOMATIC_SLOWED);
            badservices.Add("Fax", ServiceType.MANUAL);
            badservices.Add("fdPHost", ServiceType.MANUAL);
            badservices.Add("FDResPub", ServiceType.MANUAL);
            badservices.Add("lfsvc", ServiceType.MANUAL);
            badservices.Add("OneSyncSvc_7d87e", ServiceType.AUTOMATIC_SLOWED);
            badservices.Add("irmon", ServiceType.MANUAL);
            badservices.Add("lltdsvc", ServiceType.MANUAL);
        }

        /*
        private string[] badservices =
        {
            "lltdsvc",
            "MessagingService_7d87e",
            "SmsRouter",
            "PNRPsvc",
            "p2psvc",
            "p2pimsvc",
            "PerfHost",
            "PhoneSvc",
            "PNRPAutoReg",
            "RasAuto",
            "RasMan",
            "SessionEnv",
            "TermService",
            "UmRdpService",
            "RpcSs",
            "RpcLocator",
            "RpcEptMapper",
            "Server",
            "SNMPTRAP",
            "SQLWriter",
            "SSDPSRV",
            "lmhosts",
            "TapiSrv",
            "UserDataSvc_7d87e",
            "UnistoreSvc_7d87e",
            "WinHttpAutoProxySvc",
            "WwanSvc"
        };
        */

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disables insecure services such as Discovery and many others";
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.INSECURE_SERVICE_POLICY;
        }

        public override bool isEnabled()
        {
            if(Config.getConfig().getBoolean("insecureservices"))
            {
                return Config.getConfig().getBoolean("insecureservices");
            }
            return false;
        }

        public override void apply()
        {
            throw new NotImplementedException();
        }

        public override void unapply()
        {
            throw new NotImplementedException();
        }

        public override Button getButton()
        {
            return this.gui.insecureservicesbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return this.gui.insecureserviceprogress;
        }

        public override bool hasIncompatibilityIssues()
        {
            return false;
        }

        [Obsolete]
        public override bool isLanguageDepended()
        {
            return false;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSafeForBussiness()
        {
            return false;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isUserControlRequired()
        {
            return false;
        }
    }
}
