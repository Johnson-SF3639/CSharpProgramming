using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            double value;
            Console.Write("Enter the Terms : ");
            value = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=value; i++){
            Console.WriteLine($"Number is : {i} and cube of the {i} is : "+ Math.Pow(i,3)); 
            }               
        }
    }
}