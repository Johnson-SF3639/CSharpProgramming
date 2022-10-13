using System;
namespace Question2{
    class Program{
        public static void Main(string[] args)
        {
            int number, number1=0, number2=1, count=1;
            
            Console.Write($"Enter the number of terms to display : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Here is the Fibonacci series up to {number} terms : 0 1");

            for(int i=0; i<number-2; i++){
                count=number1+number2;
                number1 = number2;
                number2 =count;
                Console.Write($" {count}");
            }
            
        }
    }
}