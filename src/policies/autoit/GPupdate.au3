#RequireAdmin
func updatePolicy()
   Run("cmd.exe")
   WinWait("Administrator: C:\Windows\SYSTEM32\cmd.exe")
   WinActivate("Administrator: C:\Windows\SYSTEM32\cmd.exe")
   Send("gpupdate.exe /force")
   Sleep(400)
   Send("{ENTER}")
   Sleep(3400)
   WinClose("Administrator: C:\Windows\SYSTEM32\cmd.exe")
EndFunc