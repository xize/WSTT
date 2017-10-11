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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class UpdatePolicy : SecurityPolicy
    {

        public async override void Apply()
        {
            await Task.Run(()=>this.ExecuteCMD("gpupdate.exe /force", true));
        }

        public override Button GetButton()
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            return "updates the policy, this is not a UI element.";
        }

        public override string GetName()
        {
            return "update policy";
        }

        public override ProgressBar GetProgressbar()
        {
            throw new NotImplementedException();
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.UPDATE_POLICY;
        }

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        public override bool IsEnabled()
        {
            return false;
        }
        public override bool IsCertificateDepended()
        {
            return false;
        }

        public override Certificate GetCertificate()
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return false;
        }

        public override bool IsMacro()
        {
            return true;
        }

        public override bool IsSafeForBussiness()
        {
            return false;
        }

        public override bool IsSecpolDepended()
        {
            return true;
        }

        public override bool IsUserControlRequired()
        {
            return false;
        }

        public override void Unapply()
        {
            
        }
    }
}
