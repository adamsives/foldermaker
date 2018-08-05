# readme
## What is it for?
foldermaker is an application that creates a workspace for you every-day files (memos, drafts, downloads etc). This is a place to put your files that is
1.	Away from your desktop, reducing clutter
2.	A means of organising your work by date helping you recall what you were doing and when
3.	An archive for potentially useful material
When the question comes up “Hey, you worked on that project last March, do you still have those image files we used?”. The answer will (partly) be, “I’ll just search last March’s folder”.

## What does it do?
It creates a folder every day, in a ‘ddMMyyyy’ format in the user My Document folder. For example

My Documents:
/2017

       /01 January
       /02 February
       /03 March
             /01032017
             /02032017
             /02032017 [your file(s) are here!]
## How does it work?
This runs as a Windows service. The code writes a folder for the current year if it doesn’t exist, it writes the month in a ‘0n Mmm’ format if it doesn’t exist and the day in ‘ddMMyyyy’ format if (you guessed it) it doesn’t exist.
