using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            double value1, value2;
            Console.WriteLine($"Enter The 1st Number :");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter The 2st Number :");
            value2 = Convert.ToInt32(Console.ReadLine());

            Addition();
            Subtraction();
            Multiplication();
            Division();

            void Addition(){
                Console.WriteLine($"Addition :"+(value1+value2));
            }   
            void Subtraction(){
                Console.WriteLine($"Subtraction :"+(value1-value2));
            }   
            void Multiplication(){
                Console.WriteLine($"Multiplication :"+(value1*value2));
            }   
            void Division(){
                Console.WriteLine($"Division :"+(value1/value2));
            }   
        }
    }
}