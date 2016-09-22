﻿/*
    A security toolkit for windows    

    Copyright(C) 2016 Guido Lucassen

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

namespace windows_tweak_tool.src.policies
{
    class RemoteRegistryPolicy : Policy
    {

        public override string getName()
        {
            return getType().getName();
        }

        public override string getDescription()
        {
            return "disable remote registry so hackers are unable to manage the registry outside your network";
        }

        public override PolicyType getType()
        {
            return PolicyType.REMOTE_REGISTRY_POLICY;
        }

        public override bool isMacro()
        {
            return false;
        }

        public override bool isSecpolDepended()
        {
            return false;
        }

        public override bool isEnabled()
        {
            return !isServiceStarted("RemoteRegistry");
        }

        public override void apply()
        {
            stopService("RemoteRegistry");
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\Services\RemoteRegistry", REG.HKLM);
            key.SetValue("Start", 4);
            key.Close();
        }

        public override void unapply()
        {
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\Services\RemoteRegistry", REG.HKLM);
            key.SetValue("Start", 2);
            key.Close();
            startService("RemoteRegistry");
        }

        public override Button getButton()
        {
            return gui.remoteregbtn;
        }

        public override ProgressBar getProgressbar()
        {
            return gui.remoteregprogress;
        }
    }
}
