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
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;
using windows_security_tweak_tool.src.ninite;

namespace windows_security_tweak_tool.src.optionalpolicies
{
    class NinitePolicy : OptionalPolicy
    {

        public override string GetName()
        {
            return GetOptionalPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "install applications by using third party installer called ninite.";
        }

        public override OptionalPolicyType GetOptionalPolicyType()
        {
            return OptionalPolicyType.NINITE;
        }

        public override bool IsCertificateDepended()
        {
            return true;
        }

        public override Certificate GetCertificate()
        {
            return CertProvider.NINITE.getCertificate();
        }

        public override void Apply()
        {
            foreach(NiniteOption option in NiniteOption.Values())
            {
                if(option.IsEnabled())
                {
                    this.Add(option);
                }
            }
            this.DownloadNiniteInstaller(this.GetNiniteURL());
        }

        public override void Unapply()
        {
            //not supported   
        }

        public override Button GetButton()
        {
            return gui.niniteinstallbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return null;
        }
    }
}
