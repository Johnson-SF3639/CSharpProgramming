using System;
namespace ByNoOfArgs{
    class Program{

        static void Display(int number){
            Console.WriteLine($"Args : {number}");
        }

        static void Display(int number1, int number2){
            Console.WriteLine($"Args 1 : {number1} and Args 2 : {number2}");
            
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"\n***** By Number of Args (Method Over loading)*****\n");
            
            Display(100);
            Display(100,70);

            Console.WriteLine($"\n");
        }

    }
}