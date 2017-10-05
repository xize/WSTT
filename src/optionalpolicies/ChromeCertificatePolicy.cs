using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.Properties;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class ChromeCertificatePolicy : OptionalPolicy
    {
        public override string GetName()
        {
            return GetOptionalPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "enables chrome to show certificates inside the addressbar for futher investigation\n\n"+Resources.certificate.ToString();
        }

        public override OptionalPolicyType GetOptionalPolicyType()
        {
            return OptionalPolicyType.CHROME_CERTIFICATE_POLICY;
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;

            await Task.Run(() => ApplyAsync());

            GetProgressbar().Value = 100;
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            Thread t1 = new Thread(() => Clipboard.SetText("chrome://flags/#show-cert-link"));
            t1.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            t1.Start();
            t1.Join();
            MessageBox.Show("copied url, please paste this inside the addressbar of google chrome and check the first option, press OK when you are done!", "notice:");
            Thread t2 = new Thread(() => Clipboard.Clear());
            t2.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            t2.Start();
            t2.Join();

        }

        public override void Unapply()
        {
            throw new NotImplementedException();
        }

        public override Button GetButton()
        {
            return gui.chromecertbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.chromecertprogress;
        }
    }
}
