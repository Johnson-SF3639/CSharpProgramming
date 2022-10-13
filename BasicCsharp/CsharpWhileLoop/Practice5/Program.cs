using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            int value, temp, sum=0, remember;

             Console.Write("Enter the Number : ");
             value = Convert.ToInt32(Console.ReadLine());
             remember = value;
             while(remember !=0){
                temp = remember%10;
                sum+=temp;
                remember=remember/10;                                
             }
             Console.Write($"Sum of digits of {value} is {sum}");
        }
    }
}