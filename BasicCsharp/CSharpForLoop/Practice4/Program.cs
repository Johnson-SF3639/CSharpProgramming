using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            double value;
            Console.Write("Enter the Number (Table to be calculated) : ");
            value = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=10; i++){
            Console.WriteLine($"{value} X {i} is : "+ (value*i)); 
            }               
        }
    }
}