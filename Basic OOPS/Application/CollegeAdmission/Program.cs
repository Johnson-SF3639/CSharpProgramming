using System;
namespace CollegeAdmission
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Operation.DefaultData();
            Files.Create();
            Files.ReadFile();
            Operation.MainMenu();
            Files.WriteToFile();
        }
    }
}