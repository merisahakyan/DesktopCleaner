using DesktopCleaner;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            CleanMaster.Desktop();
            string path = @"C:\Users\Dell\Desktop\New Folder";
            CleanMaster.DeleteFrom(path, "txt");
        }
    }
}
