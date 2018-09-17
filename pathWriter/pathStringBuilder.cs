using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pathWriter
{
    class pathStringBuilder
    {
        string myDocsPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        private static DateTime now = DateTime.Now;
        readonly string dayNumber = now.Day.ToString().PadLeft(2, '0');
        readonly string monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(now.Month);
        readonly string monthNumber = now.Month.ToString().PadLeft(2, '0');

        public String BuildFolderName()
        {
            string folderName = dayNumber + monthNumber + now.Year;
            return folderName;
        }

        public String BuildFullPath()
        {
            //string pathAndFolder = myDocsPath + now.Year + "\\" + monthNumber + " " + monthName + "\\" + dayNumber + monthNumber + now.Year;
            string pathAndFolder = myDocsPath + now.Year + "\\" + monthNumber + " " + monthName + "\\" + BuildFolderName();
            return pathAndFolder;
        }

    }
}
