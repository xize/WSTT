﻿/*
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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_security_tweak_tool.src.certificates;

namespace windows_security_tweak_tool.src.policies
{
    class RemoteRegistryPolicy : SecurityPolicy
    {

        public override string GetName()
        {
            return GetPolicyType().GetName();
        }

        public override string GetDescription()
        {
            return "disable remote registry so hackers are unable to manage the registry outside your network";
        }

        public override SecurityPolicyType GetPolicyType()
        {
            return SecurityPolicyType.REMOTE_REGISTRY_POLICY;
        }

        public override bool IsMacro()
        {
            return false;
        }

        public override bool IsSecpolDepended()
        {
            return false;
        }

        public override bool IsEnabled()
        {
            if(GetServiceStatus("RemoteRegistry") == ServiceType.DISABLED)
            {
                return true;
            }
            return false;
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
            StopService("RemoteRegistry", this);
            SetServiceType("RemoteRegistry", ServiceType.DISABLED);
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
            SetServiceType("RemoteRegistry", ServiceType.AUTOMATIC);
            StartService("RemoteRegistry", this);
        }

        public override Button GetButton()
        {
            return gui.remoteregbtn;
        }

        public override ProgressBar GetProgressbar()
        {
            return gui.remoteregprogress;
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

        public override bool HasIncompatibilityIssues()
        {
            return false;
        }

        public override bool IsSafeForBussiness()
        {
            return true;
        }

        public override bool IsUserControlRequired()
        {
            return false;
        }
    }
}
