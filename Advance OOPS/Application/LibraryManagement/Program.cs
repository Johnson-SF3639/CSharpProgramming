using System;
namespace LibraryManagement{
    class Program{
        public static void Main(string[] args)
        {
            Operations.DefaultData();
            Files.Create();
            Operations.MainMenu();
        }
    }
}