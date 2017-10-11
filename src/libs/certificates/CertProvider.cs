using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.certificates
{
    public class CertProvider
    {

        private static HashSet<CertProvider> providers = new HashSet<CertProvider>();

        public static CertProvider NINITE = new CertProvider("ninite", new Certificate("6E46232DB9488A989A0ECB5E386ED751C1522955", 637107459450000000));
        public static CertProvider KEEPASS = new CertProvider("keepass", new Certificate("8B602261C22C8855BF5694A6CF742AF27F618930", 636526390590000000));
        public static CertProvider GOOGLE_CHROME = new CertProvider("keepass", new Certificate("5A9272CE76A9415A4A3A5002A2589A049312AA40", 636806051990000000));
        public static CertProvider SIGCHECK_32BIT = new CertProvider("sigcheck_32bit", new Certificate("98ED99A67886D020C564923B7DF25E9AC019DF26", 636452542370000000));
        public static CertProvider SIGCHECK_64BIT = new CertProvider("sigcheck_64bit", new Certificate("98ED99A67886D020C564923B7DF25E9AC019DF26", 636452542370000000));

        private string name;
        private Certificate cert;

        private CertProvider(string name, Certificate cert)
        {
            this.name = name;
            this.cert = cert;
            providers.Add(this);
        }

        public string GetName()
        {
            return this.name;
        }

        public Certificate GetCertificate()
        {
            return this.cert;
        }

        public static CertProvider ValueOf(string name)
        {
            foreach(CertProvider c in Values())
            {
                if (c.GetName().ToLower().StartsWith(c.GetName().ToLower()))
                {
                    return c;
                }
            }
            return null;
        }

        public static CertProvider[] Values()
        {
            return providers.ToArray();
        }
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

        public string GetHash()
        {
            return certhash;
        }

        public bool Match(string certhash)
        {
            if (certhash == this.certhash)
            {
                return true;
            }
            return false;
        }

        public bool IsExpired()
        {
            DateTime current = new DateTime();
            DateTime time = new DateTime(expirationtime);

            return (time - current).TotalMilliseconds <= 0;
        }
    }
}
