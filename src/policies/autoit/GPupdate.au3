#RequireAdmin
func updatePolicy()
   Send("{LWIN}")
   Sleep(300)
   Send("gpupdate.exe /force")
   Sleep(400)
   Send("{ENTER}")
EndFunc