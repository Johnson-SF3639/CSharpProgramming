using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            int value, count=1;
            Console.Write($"Enter The Number : ");
            value = Convert.ToInt32(Console.ReadLine());

            Factorial(value);

            void Factorial(int value){
                for(int i=1; i<=value; i++){
                    count=count*i;
                }
                Console.WriteLine($"The factorial of {value}! is {count}");
            } 
        }
    }
}