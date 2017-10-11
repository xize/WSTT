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
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;
using windows_security_tweak_tool.src.mbrfilter;

namespace windows_security_tweak_tool.src.policies
{
    class MBRPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "install MBRFilter to prevent bootloader modification, this will help you against rootkits and ransomware";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.MBR_POLICY;
        }

        public override bool IsEnabled()
        {
            return MBRFilter.getMBRFilter().isInstalled();
        }

        public async override void Apply()
        {
            GetButton().Enabled = false;
            await Task.Run(() => ApplyAsync());
            SetGuiEnabled(this);
            GetButton().Enabled = true;
        }

        public void ApplyAsync()
        {
            MBRFilter.getMBRFilter().install();
        }

        public async override void Unapply()
        {
            GetButton().Enabled = false;
            await Task.Run(() => UnapplyAsync());
            SetGuiDisabled(this);
            GetButton().Enabled = true;
        }

        public void UnapplyAsync()
        {
            MBRFilter.getMBRFilter().uninstall();
        }

        public override bool IsCertificateDepended()
        {
            return false;
        }

        public override Certificate GetCertificate()
        {
            throw new NotImplementedException();
        }

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        [Obsolete]
        public override bool IsLanguageDepended()
        {
            return false;
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override Button GetButton()
        {
            return gui.mbrbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.mbrprogress;
        }

        public override bool IsSafeForBussiness()
        {
            return false;
        }

        public override bool IsUserControlRequired()
        {
            return true;
        }
    }
}
