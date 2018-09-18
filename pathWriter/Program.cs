using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace pathWriter
{
    class Program
    {

        static void Main(string[] args)
        {
            pathStringBuilder path = new pathStringBuilder();

            //Console.WriteLine(path.BuildFullPath());
            //Console.WriteLine(path.BuildFolderName());
            Console.WriteLine(path.BuildDesktopShortcutPath());

            //Console.ReadKey();
            //Comment in the below for production
            //Directory.CreateDirectory(path.BuildFullPath());



    void CreateShortcut(string linkPath, string filename)
    {
                // Create shortcut dir if not exists
                if (!Directory.Exists(linkPath))
                    Directory.CreateDirectory(linkPath);

        // COM object instance/props
        IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
        IWshRuntimeLibrary.IWshShortcut sc = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(filename);
        sc.Description = "Shortcut to today's shortcut folder.";
        //shortcut.IconLocation = @"C:\..."; 
        sc.TargetPath = linkPath;//ADAM:---------------this needs to be the path to the folder
        // save shortcut to target
        sc.Save();
    }

            CreateShortcut(path.BuildFullPath(), path.BuildDesktopShortcutPath());

        }
    }
}
