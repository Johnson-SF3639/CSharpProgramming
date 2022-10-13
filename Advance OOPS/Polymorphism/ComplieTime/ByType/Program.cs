using System;
namespace ByType{
    class Program{

        static void Disply(int number){
            Console.WriteLine($"Int Type : {number}");
        }

        static void Disply(string name){
            Console.WriteLine($"String Type : {name}");
        }


        public static void Main(string[] args)
        {
            Console.WriteLine($"\n****** By Type ******\n");
            Disply("John");
            Disply(100);
            Console.WriteLine($"\n");
            
            
            
        }
    }
}