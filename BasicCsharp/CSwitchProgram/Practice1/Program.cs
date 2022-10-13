using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            char action;
            Console.WriteLine("Enter the Grade\n\n E= Excellent\n V=Very Good\n G=Good\n A=Average\n F=Fail \n");
            action= Convert.ToChar(Console.ReadLine());
            switch(action){
                case 'E': {
                    Console.WriteLine("Excellent");
                    break;
                }
                case 'V': {
                    Console.WriteLine("Very Good");
                    break;
                }
                case 'G': {
                    Console.WriteLine("Good");
                    break;
                }
                case 'A': {
                    Console.WriteLine("Average");
                    break;
                }
                case 'F': {
                    Console.WriteLine("Fail");
                    break;
                }
            }
        }
    }
}