using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            int value;
            bool choice;

            while(true){
                Console.WriteLine("\nEnter the Value : ");
                choice = int.TryParse(Console.ReadLine(), out value);

                if(choice){
                    if(value < 6 && value > 0){
                    Console.WriteLine("Valid Input");
                    break;
                    }
                }else{
                    Console.WriteLine("Invalid Input Enter Again");
                }
            }

        }
    }
}