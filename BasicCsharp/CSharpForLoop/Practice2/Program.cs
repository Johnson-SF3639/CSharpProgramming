using System;
namespace Practice2{
    class Program{
        public static void Main(string[] args)
        {
            double value, sum=0;
            for(int i=1 ; i<=10; i++){
                value = Convert.ToInt32(Console.ReadLine());
                sum+=value;
            }      
            Console.WriteLine(sum);      
            Console.Write(sum/10);      
        }
    }
}