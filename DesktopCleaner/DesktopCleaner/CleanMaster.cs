using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace DesktopCleaner
{

    public static class CleanMaster
    {
        static string desktoppath;
        public static void Desktop()
        {
            desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            foreach (var f in Directory.GetFiles(desktoppath))
                if (f.Split('.')[f.Split('.').Length - 1] != "exe")
                    File.Delete(f);
            Console.WriteLine("Deleted!");
        }

    }
}
