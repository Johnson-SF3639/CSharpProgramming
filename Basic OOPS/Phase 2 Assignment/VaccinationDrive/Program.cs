using System;
namespace VaccinationDrive{
    class Program{
        public static void Main(string[] args)
        {
            // Operation.AddDefaultData();
            Files.Create();
            Files.ReadFile();
            Operation.MainMenu();
            Files.WriteFile();
        }
    }
}