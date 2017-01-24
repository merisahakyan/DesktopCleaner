# DesktopCleaner
For using DesktopCleaner class library add a reference to it in your project and a using clause at the top of the CS file where you want to use it.</br>
DesktopCleaner class library contains **CleanMaster** static class with _public static_ method **Desktop()**.
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
        }
```
![](https://github.com/marysahakyan/DesktopCleaner/blob/master/Desktop.gif)</br>
