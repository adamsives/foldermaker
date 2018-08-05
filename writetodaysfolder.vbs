option explicit

Dim Documents, objFSO, objFolder, objSubFolder, objFile, strUser, wshshell, wshNetwork
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set wshNetwork = CreateObject("WScript.Network")
strUser = wshNetwork.Username


Set wshshell = CreateObject("WScript.Shell")
Documents = wshShell.SpecialFolders("MyDocuments")

msgbox Documents+"\"+todaysFolder(now)

objFSO.CreateFolder(Documents+"\"+todaysFolder(now))

' date formatted as your request
Function todaysFolder(dt)
    dim d,m,y
    d = right("0" & datePart("d",dt),2)
    m = right("0" & datePart("m",dt),2)
    y = datePart("yyyy",dt)
    
    todaysFolder= y & "\" & m & " " & MonthName(datePart("m",dt),false) & "\" & d & m & y
    
End Function