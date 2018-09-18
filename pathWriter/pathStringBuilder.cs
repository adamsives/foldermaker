using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this return strings used to name the folders and shortcuts

namespace pathWriter
{
    class pathStringBuilder
    {
        string myDocsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        string desktopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
        private static DateTime now = DateTime.Now;
        readonly string dayNumber = now.Day.ToString().PadLeft(2, '0');
        readonly string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(now.Month);
        readonly string monthNumber = now.Month.ToString().PadLeft(2, '0');
        
        public String BuildFolderName()
        {
            string folderName = dayNumber + monthNumber + now.Year;
            return folderName;//e.g. on the fifth of December 2017 this will return '05122017'
        }

        public String BuildFullPath()
        {
            string pathAndFolder = myDocsPath + now.Year + "\\" + monthNumber + " " + monthName + "\\" + BuildFolderName();
            return pathAndFolder;//e.g. on the fifth of December 2017 this will return '[your documents]\2017\12 December\05121971'
        }

        public String BuildDesktopShortcutPath()
        {
            string shortcutName = desktopPath + BuildFolderName() + ".lnk";
            return shortcutName;//e.g. on the fifth of December 2017 this will return '[your desktop]\05121971.lnk'
        }
    }
}
