using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace DesktopCleaner
{

    public static class CleanMaster
    {
        static List<string> folders = new List<string>();
        static List<string> newfolders = new List<string>();
        static List<int> lengths = new List<int>();
        static string desktoppath;
        public static void Desktop()
        {
            FileFinder(@"C:\Users");
            foreach (var m in folders)
                if (m.Contains("Desktop") && (!m.Contains("Public")) && (!m.Contains("All Users")) && (!m.Contains("All Users")) && (!m.Contains("Default")))
                    newfolders.Add(m);

            foreach (var m in newfolders)
                lengths.Add(m.Length);
            int index = lengths.IndexOf(lengths.Min());
            desktoppath = newfolders[index];
            foreach (var f in Directory.GetFiles(desktoppath))
                if (f.Split('.')[f.Split('.').Length - 1] != "exe")
                    File.Delete(f);
            Console.WriteLine("Deleted!");
        }
        static void FileFinder(string path)
        {
            if (path.Contains("Desktop"))
                folders.Add(path);
            try
            {
                foreach (var d in Directory.GetDirectories(path))
                    FileFinder(d);
            }
            catch (UnauthorizedAccessException ex)
            {
                return;
            }

        }
    }
}
