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
            Process p = Process.Start("takeown.exe", "/F " + file + " /A");
            p.WaitForExit();
            p.Close();
            p.Dispose();
            Process p1 = Process.Start("icacls", file + " /grant Administrators:f");
            p1.WaitForExit();
            p1.Close();
            p1.Dispose();
        }

        public void RestoreToTrustedInstaller(string file)
        {
            Process p = Process.Start("icacls", file+" /grant \"NT SERVICE\\TrustedInstaller\":f");
            p.WaitForExit();
            p.Close();
            p.Dispose();
            Process p1 = Process.Start("icacls", file+ " /reset /t  /c /q");
            p1.WaitForExit();
            p1.Close();
            p1.Dispose();
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
