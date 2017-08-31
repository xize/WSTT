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
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_security_tweak_tool.src.policies.components
{
    abstract class Services : Registry
    {

        private int timeout = 500;

        /**
        * <summary>
        *      <para>returns true if the service is started otherwise false</para>
        * </summary>
        *
        * <returns>bool</returns>
        **/
        public bool IsServiceStarted(string service)
        {
            if(!DoesServiceExist(service))
            {
                return false;
            }
            ServiceController controller = ServiceController.GetServices().FirstOrDefault(serviceController => serviceController.ServiceName == service);
            controller.Refresh();

            bool isStarted = false;

            if(controller.Status == ServiceControllerStatus.Running)
            {
                isStarted = true;
            }

            //make it null so it is marked for GC when it wasn't null already, Dispose method will give a exception because it was already null.
            controller = null;

            return isStarted;
        }

        /**
        * <summary>
        *      <para>starts the service by using the name</para>
        * </summary>
        **/
        public void StartService(string service, SecurityPolicy p)
        {
            if (!DoesServiceExist(service))
            {
                return;
            }
            ServiceController controller = ServiceController.GetServices().FirstOrDefault(serviceController => serviceController.ServiceName == service);
            controller.Start();
            try
            {
                controller.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(timeout));
            } catch(System.ServiceProcess.TimeoutException)
            {
                MessageBox.Show("the service " + service + " could not be started timeout!, please try again.", "error!");
                p.getButton().Enabled = true;
            }

            controller.Dispose();
        }

        /**
        * <summary>
        *      <para>starts the service by using the name</para>
        * </summary>
        **/
        public void StopService(string service, SecurityPolicy p)
        {
            if (!DoesServiceExist(service))
            {
                return;
            }

            ServiceController controller = ServiceController.GetServices().FirstOrDefault(serviceController => serviceController.ServiceName == service);

            try
            {
                controller.Stop();
                controller.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(timeout));
            } catch(System.ServiceProcess.TimeoutException)
            {
                MessageBox.Show("the service " + service + " could not be stopped timeout!, please try again.", "error!");
                p.getButton().Enabled = true;
            }

            controller.Dispose();
        }

        /**
        * <summary>
        *      <para>sets the service type of the called type</para>
        * </summary>
        **/
        public void SetServiceType(string service, ServiceType type)
        {
            if (!DoesServiceExist(service))
            {
                return;
            }

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

            this.ExecuteCMD("sc config " + service + " start= " + stype, true);
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
        public ServiceType GetServiceStatus(string service)
        {
            if (!DoesServiceExist(service))
            {
                throw new Exception("service "+service+" does not exist, and cannot be called in getServiceStatus()");
            }
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
        public bool DoesServiceExist(string service)
        {
            ServiceController c = ServiceController.GetServices().FirstOrDefault(serviceController => serviceController.ServiceName == service);

            bool serviceb = false;

            if(c != null)
            {
                serviceb = true;
            }

            //make it null so it is marked for GC when it wasn't null already, Dispose method will give a exception because it was already null.
            c = null;

            return serviceb;
        }

        public void ExecuteCMD(string arguments, bool ghost)
        {
            ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
            info.Arguments = "/c "+arguments;
            if (ghost)
            {
                info.UseShellExecute = false;
                info.CreateNoWindow = true;
            }
            Process p = Process.Start(info);
            while (!p.HasExited) { }
            p.Close();
            p.Dispose();
        }

    }
}
