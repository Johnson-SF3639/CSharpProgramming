using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            int value1=0, value2=1, count, sum=1;
             Console.Write("Enter the Number : ");
             count = Convert.ToInt32(Console.ReadLine());
             Console.Write($"Here is the Fibonacci series upto to {count} terms : 0 1 ");
             while((count-2) != 0){
                sum=value1+value2;
                Console.Write($"{sum} ");
                value1=value2; 
                value2=sum;   
                count--;       
             }

        }
    }
}