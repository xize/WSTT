using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_security_tweak_tool.src.libs.permission_api
{
    class Permission
    {

        private static Permission api;

        private Permission() { }

        public void SetToAdministrator(string file)
        {
            ProcessStartInfo info = new ProcessStartInfo("takeown.exe");
            info.Arguments = "/F "+file+"/A";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Close();
            p.Dispose();
            ProcessStartInfo info2 = new ProcessStartInfo("icacls");
            info2.Arguments = file + " /grant Administrators:f";
            info2.CreateNoWindow = true;
            info2.UseShellExecute = false;
            Process p1 = Process.Start(info2);
            p1.WaitForExit();
            p1.Close();
            p1.Dispose();
        }

        public void RestoreToTrustedInstaller(string file)
        {
            /*
            ProcessStartInfo info = new ProcessStartInfo("takeown");
            info.Arguments = "/R /F "+file;
           // info.UseShellExecute = false;
           // info.CreateNoWindow = true;
            Process p = Process.Start(info);
            p.WaitForExit();
            p.Close();
            p.Dispose();
            */

            ProcessStartInfo info1 = new ProcessStartInfo("icacls");
            info1.Arguments = file + " /remove Administrators:dwm"; //<- this does not work for some reason
            info1.UseShellExecute = false;
            info1.CreateNoWindow = true;
            Process p1 = Process.Start(info1);
            p1.WaitForExit();
            p1.Close();
            p1.Dispose();

            ProcessStartInfo info2 = new ProcessStartInfo("icacls");
            info2.Arguments = file + " /grant \"NT SERVICE\\TrustedInstaller\":f";
            info2.UseShellExecute = false;
            info2.CreateNoWindow = true;
            Process p3 = Process.Start(info2);
            p3.WaitForExit();
            p3.Close();
            p3.Dispose();

        }

        public static Permission GetPermissionAPI()
        {
            if(api == null)
            {
                api = new Permission();
            }
            return api;
        }

    }
}
