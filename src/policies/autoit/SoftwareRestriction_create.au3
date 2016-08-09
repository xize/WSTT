#RequireAdmin
#include "GPupdate.au3"
; functions start ===>
func pressOK()
   MouseClick("primary", 360, 480, 1, 0)
EndFunc

func setTrustedPolicy()
   MouseClick("primary", 380, 200, 2, 100)
   WinWait("Eigenschappen van Vertrouwde uitgevers")
   MouseClick("primary", 260, 160, 1, 100)
   MouseClick("primary", 260, 260, 1, 100)
   MouseClick("primary", 260, 363, 1, 100)
   pressOK()
EndFunc

func setEnforcementPropertyPolicy()
   MouseClick("primary", 280, 160, 2, 0)
   WinWait("Eigenschappen van Afdwingen")
   MouseClick("primary", 260, 173, 1, 0)
   MouseClick("primary", 260, 307, 1, 0)
   pressOK()
EndFunc

func addPolicy($d)
   MouseClick("right", 280, 480, 1, 1)
   sleep(300)
   MouseClick("primary", 290, 556, 1, 1)
   WinWait("Regel voor nieuw pad")
   Send($d)
   MouseClick("primary", 360, 480, 1, 1)
   sleep(300)
EndFunc

func close()
   MouseClick("primary", 785, 3, 1, 0)
EndFunc
;<=== end functions

Send("{LWIN}")
Sleep(400)
Send("secpol.msc")
Sleep(400)
Send("{ENTER}")
WinWait("Lokaal beveiligingsbeleid")
WinActive("Lokaal beveiligingsbeleid")
MouseClick("primary", 48, 207, 1, 100)
sleep(500)
MouseClick("right", 45, 207, 1, 100)
Sleep(500)
MouseClick("primary", 48, 212, 1, 100)
Sleep(500)
Send("{ENTER}")
Sleep(500)
;configurating vertrouwde uitgevers
setTrustedPolicy()
;configurating afdwingen
setEnforcementPropertyPolicy()
;extra regels toevoegen
MouseClick("primary", 280, 139, 2, 1)
sleep(300)
addPolicy("%temp%\*.exe")
addPolicy("%temp%\*.dll")
addPolicy("%temp%\*.sys")
addPolicy("%temp%\*.au3")
addPolicy("%temp%\*\*.exe")
addPolicy("%temp%\*\*.dll")
addPolicy("%temp%\*\*.sys")
addPolicy("%temp%\*\*.au3")
addPolicy("%localappdata%\*.exe")
addPolicy("%localappdata%\*.dll")
addPolicy("%localappdata%\*.au3")
addPolicy("%systemdir%\system32\WindowsPowershell\*\*.exe")
addPolicy("%systemdir%\syswow64\WindowsPowershell\*\*.exe")
;closing the script...
close()
updatePolicy()