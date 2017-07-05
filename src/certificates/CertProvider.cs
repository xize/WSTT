using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src.certificates
{
    public class CertProvider
    {

        private static HashSet<CertProvider> providers = new HashSet<CertProvider>();

        public static CertProvider NINITE = new CertProvider("ninite", new Certificate("6E46232DB9488A989A0ECB5E386ED751C1522955", 1)); //TODO: change 1 to the actual expiriation date of the cert.
        public static CertProvider KEEPASS = new CertProvider("keepass", new Certificate("8B602261C22C8855BF5694A6CF742AF27F618930", 1)); //TODO: change 1 to the actual expiriation date of the cert.
        public static CertProvider GOOGLE_CHROME = new CertProvider("keepass", new Certificate("5A9272CE76A9415A4A3A5002A2589A049312AA40", 1)); //TODO: change 1 to the actual expiriation date of the cert.

        private string name;
        private Certificate cert;

        private CertProvider(string name, Certificate cert)
        {
            this.name = name;
            this.cert = cert;
            providers.Add(this);
        }

        public string getName()
        {
            return this.name;
        }

        public Certificate getCertificate()
        {
            return this.cert;
        }

        public CertProvider valueOf(string name)
        {
            foreach(CertProvider c in values())
            {
                if (c.getName().ToLower().StartsWith(c.getName().ToLower()))
                {
                    return c;
                }
            }
            return null;
        }

        public CertProvider[] values()
        {
            return providers.ToArray();
        }

        public class Certificate
        {
            private string certhash;
            private long expirationtime;

            public Certificate(string certhash, long expirationtime)
            {
                this.certhash = certhash;
                this.expirationtime = expirationtime;
            }

            public string getHash()
            {
                return certhash;
            }

            public bool match(string certhash)
            {
                if(certhash == this.certhash)
                {
                    return true;
                }
                return false;
            }

            public bool isExpired()
            {
                DateTime current = new DateTime();
                DateTime time = new DateTime(expirationtime);

                return (time-current).TotalMilliseconds <= 0;
            }
        }
    }
}
