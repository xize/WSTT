#RequireAdmin
func updatePolicy()
   Run("cmd.exe")
   WinWait("Administrator: C:\Windows\SYSTEM32\cmd.exe")
   WinActivate("Administrator: C:\Windows\SYSTEM32\cmd.exe")
   Send("@title updating group policies, please wait till the window has been closed!")
   Send("please wait when the window has been closed ;-) or you may have to remove the configuration file in %appdata%\wtt\config.yml")
   Send("gpupdate.exe /force")
   Sleep(400)
   Send("{ENTER}"
   Sleep(3400)
   WinClose("Administrator: C:\Windows\SYSTEM32\cmd.exe")
EndFunc