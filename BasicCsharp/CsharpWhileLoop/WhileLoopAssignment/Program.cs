using System;
namespace WhileLoopAssignment{
    class Program{
        public static void Main(string[] args)
        {
            int value,i=0;
            bool choice;

            Console.WriteLine("Enter the Value : ");
            value = Convert.ToInt32(Console.ReadLine());

            while(true){
                if(i%2 == 0){
                    Console.Write($"{i} ");
                }
                i++;
                if(i > value){
                    break;
                }
            }

            while(true){
                Console.WriteLine("\nEnter the Value : ");
                choice = int.TryParse(Console.ReadLine(), out value);

                if(choice){
                    Console.WriteLine("Congratulations It's Valid Input Format. \n ");
                    break;
                }else{
                    Console.WriteLine("Invalid input format. Please enter the input in number format");
                }
            }
        }
    }
}