using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
            if (controller.Status == ServiceControllerStatus.Running)
            {
                return true;
            }
            return false;
        }

        /**
        * <summary>
        *      <para>starts the service by using the name</para>
        * </summary>
        **/
        public void startService(string service)
        {
            ServiceController controller = new ServiceController(service);

            Console.WriteLine("service status: " + controller.Status);

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
            if (controller.Status == ServiceControllerStatus.Running || controller.Status == ServiceControllerStatus.StartPending)
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
        public void setServiceType(string service, ServiceType type)
        {
            int stype = 4;
            switch (type)
            {
                case ServiceType.AUTOMATIC_SLOWED:
                    stype = 1;
                    break;
                case ServiceType.AUTOMATIC:
                    stype = 2;
                    break;
                case ServiceType.MANUAL:
                    stype = 3;
                    break;
                case ServiceType.DISABLED:
                    stype = 4;
                    break;
                default:
                    stype = 4;
                    break;
            }
            RegistryKey key = getRegistry(@"SYSTEM\CurrentControlSet\Services\" + service, REG.HKLM);
            key.SetValue("Start", stype);
            key.Close();
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

    }
}
