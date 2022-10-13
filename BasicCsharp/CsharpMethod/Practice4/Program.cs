using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            int value, value1=0, value2=1, temp;
            Console.Write($"Input number of Fibonacci Series : ");
            value = Convert.ToInt32(Console.ReadLine());

            Fibonacci(value);

            void Fibonacci(int value){
                Console.Write($"Input number of Fibonacci Series : 0 1 ");
                for(int i=0; i<(value-2); i++){
                    temp=value1+value2;
                    Console.Write($"{temp} ");
                    value1=value2;
                    value2=temp;
                }

            }   
        }
    }
}