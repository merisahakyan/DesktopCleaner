# DesktopCleaner
For using DesktopCleaner class library add a reference to it in your project and a using clause at the top of the CS file where you want to use it.</br>
DesktopCleaner class library contains **CleanMaster** static class with _public static_ methods **Desktop()** and **DeleteFrom()**.</br>
* **Desktop()** method deletes all the unnecessary files from computers desktop.
* **DeleteFrom(path,suffix)** method deletes files with a given suffix from a given path.

```cs
using System;
using System.IO;
namespace DesktopCleaner
{
    public static class CleanMaster
    {
        public static void Desktop()
        {
            desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            foreach (var f in Directory.GetFiles(desktoppath))
                if (f.Split('.')[f.Split('.').Length - 1] != "exe")
                    File.Delete(f);
            Console.WriteLine("Deleted!");
        }
        
        public static void DeleteFrom(string path,string suffix)
        {
            foreach (var f in Directory.GetFiles(path))
                if (f.Split('.')[f.Split('.').Length - 1] == suffix)
                    File.Delete(f);
            Console.WriteLine($"The .{suffix} files are deleted from {path}");
        }
       
     }
}
```
Use the Environment class to retrieve information such as command-line arguments, the exit code, environment variable settings,</br>
contents of the call stack, time since last system boot, and the version of the common language runtime.</br>
###How to use:</br>
```cs
static void Main(string[] args)
        {
            CleanMaster.Desktop();
            CleanMaster.DeleteFrom("C:\\Users\\Dell\\Desktop\\New Folder", "txt");
        }
```
![](https://github.com/marysahakyan/DesktopCleaner/blob/master/Desktop.gif)</br>
