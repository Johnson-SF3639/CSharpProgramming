using System;
namespace Practice2{
    class Program{
        public static void Main(string[] args)
        {
            int count, sum=0;
             Console.Write("Enter the Number : ");
            count = Convert.ToInt32(Console.ReadLine());
             while(count!=0){
                sum=count*count+sum;  
                count--;           
             }
             Console.WriteLine($"{sum}");
             
        }
    }
}