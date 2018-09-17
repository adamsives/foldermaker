using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pathWriter
{
    class Program
    {

        static void Main(string[] args)
        {
            pathStringBuilder path = new pathStringBuilder();

            Console.WriteLine(path.BuildFullPath());
            Console.WriteLine(path.BuildFolderName());

            Console.ReadKey();

            Directory.CreateDirectory(path.BuildFullPath());

    

        }
    }
}
