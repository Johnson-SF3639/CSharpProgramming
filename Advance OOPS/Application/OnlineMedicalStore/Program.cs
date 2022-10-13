using System;
namespace OnlineMedicalStore{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine($"\n********************************************************");
            // Operations.DefaultData();
            Files.Create();
            Files.ReadFile();
            Operations.MainMenu();
            Files.WriteToFile();
            Console.WriteLine($"\n********************************************************");
        }
    }
}