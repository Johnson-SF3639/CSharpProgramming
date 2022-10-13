using System;
namespace BloodBank{
    class Program{
        public static void Main(string[] args)
        {
            Files.Create();
            Files.ReadFile();
            Operations.MainMenu();
            Files.WriteFile();
        }
    }
}