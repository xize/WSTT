/*
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

namespace windows_tweak_tool.src.policies.components
{
    abstract class Services : Registry
    {

        /**
        * <summary>
        *      <para>returns true if the service is started otherwise false</para>
        * </summary>
        *
        * <returns>bool</returns>
        **/
        public bool isServiceStarted(string service)
        {
            ServiceController controller = new ServiceController(service);
            controller.Refresh();
            return controller.Status == ServiceControllerStatus.Running;
        }

        /**
        * <summary>
        *      <para>starts the service by using the name</para>
        * </summary>
        **/
        public void startService(string service)
        {
            ServiceController controller = new ServiceController(service);
            controller.Refresh();
            if (controller.CanStop && controller.Status == ServiceControllerStatus.Stopped)
            {
                controller.Start();
                controller.WaitForStatus(ServiceControllerStatus.Running);
            }
        }

        /**
        * <summary>
        *      <para>starts the service by using the name</para>
        * </summary>
        **/
        public void stopService(string service)
        {
            ServiceController controller = new ServiceController(service);
            controller.Refresh();
            if (controller.CanStop)
            {
                controller.Stop();
                controller.WaitForStatus(ServiceControllerStatus.Stopped);
            }
        }

        /**
        * <summary>
        *      <para>sets the service type of the called type</para>
        * </summary>
        **/
        public void setServiceType(string service, ServiceType type, bool useronly)
        {
            string stype = "demand";
            switch (type)
            {
                case ServiceType.AUTOMATIC_SLOWED:
                    stype = "delayed-auto";
                    break;
                case ServiceType.AUTOMATIC:
                    stype = "auto";
                    break;
                case ServiceType.MANUAL:
                    stype = "demand";
                    break;
                case ServiceType.DISABLED:
                    stype = "disabled";
                    break;
                default:
                    stype = "demand";
                    break;
            }
            /*
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\Services\" + service, (useronly ? REG.HKCU : REG.HKLM));
            key.SetValue("Start", stype);
            key.Close();
            */

            this.executeCMD("sc config " + service + " start= " + stype, true);
        }

        /**
        * <summary>
        *      <para>the service types</para>
        * </summary>
        **/
        public enum ServiceType
        {
            AUTOMATIC_SLOWED,
            AUTOMATIC,
            MANUAL,
            DISABLED
        }

        /**
        * <summary>
        *      <para>returns the service type</para>
        * </summary>
        **/
        public ServiceType getServiceStatus(string service)
        {
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\Services\" + service, REG.HKLM);
            int status = (int)key.GetValue("Start");
            switch (status)
            {
                case 1:
                    return ServiceType.AUTOMATIC_SLOWED;
                case 2:
                    return ServiceType.AUTOMATIC;
                case 3:
                    return ServiceType.MANUAL;
                case 4:
                    return ServiceType.DISABLED;
                default:
                    return ServiceType.MANUAL;
            }
        }

        /**
        * <summary>
        *      <para>returns true if the service exist otherwise false</para>
        * </summary>
        **/
        public bool doesServiceExist(string service)
        {
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\Services\" + service, REG.HKLM);
            if(key != null)
            {
                return true;
            }
            return false;
        }

        public void executeCMD(string arguments, bool ghost)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/b " + arguments;
            if (ghost)
            {
                info.UseShellExecute = false;
                info.CreateNoWindow = true;
            }
            Process p = Process.Start(info);
            while (p.HasExited) { }
            p.Close();
            p.Dispose();
        }

    }
}
