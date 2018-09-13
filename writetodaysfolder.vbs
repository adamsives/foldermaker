option explicit
On Error Resume Next

Dim Documents, objFSO, strUser, wshNetwork, wshshell
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set wshNetwork = CreateObject("WScript.Network")
strUser = wshNetwork.Username

Set wshshell = CreateObject("WScript.Shell")
Documents = wshShell.SpecialFolders("MyDocuments")

dim d,m,y
d = right("0" & datePart("d",now),2)
m = right("0" & datePart("m",now),2)
y = datePart("yyyy",now)
    
objFSO.CreateFolder(wshShell.SpecialFolders("MyDocuments")) & "\" & y & "\"
objFSO.CreateFolder(wshShell.SpecialFolders("MyDocuments")) & "\" & y & "\" & m & " " & MonthName(datePart("m",now),false)
objFSO.CreateFolder(wshShell.SpecialFolders("MyDocuments")) & "\" & y & "\" & m & " " & MonthName(datePart("m",now),false) & "\" & d & m & y