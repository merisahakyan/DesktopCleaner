using System;
using System.IO;


namespace DesktopCleaner
{

    public static class CleanMaster
    {
        static string desktoppath;
        /// <summary>
        /// 
        /// </summary>
        public static void Desktop()
        {
            desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            foreach (var f in Directory.GetFiles(desktoppath))
                if (f.Split('.')[f.Split('.').Length - 1] != "exe")
                    File.Delete(f);
            Console.WriteLine("Deleted!");
        }
        /// <summary>
        /// Deletes files with given suffixes from the given path.
        /// Path form:"C:\...\FolderName.
        /// Suffix form: pdf,exe,txt...
        /// </summary>
        /// <param name="path">  </param>
        /// <param name="suffix"></param>


        public static void DeleteFrom(string path,string suffix)
        {
            foreach (var f in Directory.GetFiles(path))
                if (f.Split('.')[f.Split('.').Length - 1] == suffix)
                    File.Delete(f);
            Console.WriteLine($"The .{suffix} files are deleted from {path}");
        }

    }
}
