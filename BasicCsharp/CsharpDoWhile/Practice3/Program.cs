using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            int value,value1=0, value2=1, sum=0;
            string choice = "", pass;

            Console.Write($"Input number of terms to display : ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Here is the Fibonacci series upto to {value} terms : {value1} {value2} ");
            do{
                sum=value1+value2;
                Console.Write($"{sum} ");
                value1=value2;
                value2=sum;
                value--;
            }while((value-2) > 0);

        }
    }
}