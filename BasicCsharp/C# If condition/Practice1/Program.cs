using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter the Positive integer");
            value = Convert.ToInt32(Console.ReadLine());
            if(value%2 ==0){
                Console.WriteLine($"{value} is an Even integer");                
            }else{
                Console.WriteLine($"{value} is an Odd integer");                
            }

        }
    }
}