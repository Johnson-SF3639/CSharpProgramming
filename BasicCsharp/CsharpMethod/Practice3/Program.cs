using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            int value1, value2, temp;
            Console.WriteLine($"Enter The 1st Number :");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter The 2st Number :");
            value2 = Convert.ToInt32(Console.ReadLine());

            SwapMethod(value1, value2);

            void SwapMethod(int value1, int value2){
                temp=value1;
                value1=value2;
                value2=temp;
                Console.WriteLine($"Now The 1st Number is :{value1} , And The 2nd Number is : {value2}");
            }   
        }
    }
}