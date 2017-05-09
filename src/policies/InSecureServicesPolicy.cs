using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_tweak_tool.src.policies
{
    class InSecureServicesPolicy : SecurityPolicy
    {

        private Dictionary<String, ServiceType> services = new Dictionary<string, ServiceType>();

        public InSecureServicesPolicy()
        {
            services.Add("AJRouter", ServiceType.MANUAL);
            services.Add("AppReadiness", ServiceType.MANUAL); //windows store
            services.Add("ALG", ServiceType.MANUAL);
            services.Add("AppXSvc", ServiceType.MANUAL); // windows store
            services.Add("BthHFSrv", ServiceType.MANUAL); // bluetooth service
            services.Add("bthserv", ServiceType.MANUAL); // bluetooth service
            services.Add("PeerDistSvc", ServiceType.MANUAL);
            
            //services.Add("CDPUserSvc_*", ServiceType.AUTOMATIC); // unknown

            services.Add("ClipSVC", ServiceType.MANUAL); // windows store
            services.Add("Browser", ServiceType.MANUAL);
            services.Add("DiagTrack", ServiceType.AUTOMATIC);
            services.Add("CoreMessagingRegistrar", ServiceType.AUTOMATIC);
            services.Add("DsSvc", ServiceType.MANUAL);
            services.Add("DcpSvc", ServiceType.MANUAL);
            services.Add("DoSvc", ServiceType.AUTOMATIC);
            services.Add("DsmSvc", ServiceType.MANUAL);
            services.Add("TrkWks", ServiceType.DISABLED);
            services.Add("dmwappushservice", ServiceType.MANUAL);
            services.Add("Dnscache", ServiceType.MANUAL);
            services.Add("MapsBroker", ServiceType.AUTOMATIC);
            services.Add("EntAppSvc", ServiceType.MANUAL);
            services.Add("EapHost", ServiceType.MANUAL);
            services.Add("Fax", ServiceType.MANUAL);
            services.Add("fhsvc", ServiceType.MANUAL);
            services.Add("fdPHost", ServiceType.MANUAL);
            services.Add("FDResPub", ServiceType.MANUAL);
            services.Add("XblGameSave", ServiceType.MANUAL);
            services.Add("lfsvc", ServiceType.AUTOMATIC);
            services.Add("HomeGroupProvider", ServiceType.MANUAL);
            services.Add("irmon", ServiceType.MANUAL);
            services.Add("iphlpsvc", ServiceType.AUTOMATIC);
            services.Add("KtmRm", ServiceType.MANUAL);
            services.Add("lltdsvc", ServiceType.MANUAL);
            services.Add("smphost", ServiceType.MANUAL);
            services.Add("SmsRouter", ServiceType.MANUAL);
            services.Add("diagnosticshub.standardcollector.service", ServiceType.MANUAL);
            services.Add("XboxNetApiSvc", ServiceType.MANUAL);
            services.Add("NcdAutoSetup", ServiceType.MANUAL);
            services.Add("ose", ServiceType.MANUAL);
            services.Add("CscService", ServiceType.MANUAL);
            services.Add("defragsvc", ServiceType.MANUAL);
            services.Add("PNRPsvc", ServiceType.MANUAL);
            services.Add("p2psvc", ServiceType.MANUAL);
            services.Add("p2pimsvc", ServiceType.MANUAL);
            services.Add("PhoneSvc", ServiceType.MANUAL);
            services.Add("PNRPAutoReg", ServiceType.MANUAL);
            services.Add("RmSvc", ServiceType.MANUAL);
            services.Add("RasAuto", ServiceType.MANUAL);
            services.Add("RasMan", ServiceType.MANUAL);
            services.Add("SessionEnv", ServiceType.MANUAL);
            //services.Add("TermService", ServiceType.MANUAL);
            services.Add("UmRdpService", ServiceType.MANUAL);
            //services.Add("RpcSs", ServiceType.AUTOMATIC);
            //services.Add("RpcLocator", ServiceType.MANUAL);
            services.Add("RetailDemo", ServiceType.MANUAL);
            //services.Add("RpcEptMapper", ServiceType.AUTOMATIC);
            services.Add("SstpSvc", ServiceType.MANUAL);
            services.Add("SensorDataService", ServiceType.MANUAL);
            services.Add("SensrSvc", ServiceType.MANUAL);
            services.Add("SensorService", ServiceType.MANUAL);
            services.Add("LanmanServer", ServiceType.MANUAL);
            services.Add("CDPSvc", ServiceType.AUTOMATIC);
            services.Add("shpamsvc", ServiceType.DISABLED);
            services.Add("SNMPTRAP", ServiceType.MANUAL);
            services.Add("SSDPSRV", ServiceType.MANUAL);
            services.Add("StateRepository", ServiceType.MANUAL);
            services.Add("WiaRpc", ServiceType.MANUAL);
            services.Add("WpnService", ServiceType.AUTOMATIC);
            services.Add("lmhosts", ServiceType.MANUAL);
            services.Add("TapiSrv", ServiceType.MANUAL);
            services.Add("Themes", ServiceType.AUTOMATIC);
            services.Add("WebClient", ServiceType.MANUAL);
            services.Add("WalletService", ServiceType.MANUAL);
            services.Add("WinRM", ServiceType.MANUAL);
            services.Add("workfolderssvc", ServiceType.MANUAL);
            //services.Add("LanmanWorkstation", ServiceType.AUTOMATIC);
            services.Add("WwanSvc", ServiceType.MANUAL);
            services.Add("XblAuthManager", ServiceType.MANUAL);
        }

        public override string getName()
        {
            return getType().getName();
        }

        public override SecurityPolicyType getType()
        {
            return SecurityPolicyType.IN_SECURE_SERVICES_POLICY;
        }

        public override string getDescription()
        {
            return "disables all the services not needed by Windows";
        }

        public override bool isEnabled()
        {
            return Config.getConfig().getBoolean("insecure-services");
        }

        public override void apply()
        {
            getButton().Enabled = false;

            foreach (KeyValuePair<string, ServiceType> service in services)
            {
                if(this.isServiceStarted(service.Key))
                {
                    this.stopService(service.Key);
                }
                    this.setServiceType(service.Key, ServiceType.DISABLED, false);
            }
            Config.getConfig().put("insecure-services", true);
            getButton().Enabled = true;
            setGuiEnabled(this);
        }

        public override void unapply()
        {
            getButton().Enabled = false;

            foreach (KeyValuePair<string, ServiceType> service in services)
            {
                this.setServiceType(service.Key, service.Value, false);
            }
            Config.getConfig().put("insecure-services", false);

            getButton().Enabled = true;
            setGuiDisabled(this);

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
            return true;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isUserControlRequired()
        {
            return false;
        }

        public override Button getButton()
        {
            return gui.insecureservicesbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.insecureserviceprogress;
        }
    }
}
