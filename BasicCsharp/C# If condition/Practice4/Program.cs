using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.WriteLine("Enter the 1st Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number : ");
            number3 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2 && number1 > number3){
                Console.WriteLine("The 1nd Number is the greatest among three");
            }else if(number2 > number1 && number2 > number3){
                Console.WriteLine("The 2nd Number is the greatest among three");
            }else{
                Console.WriteLine("The 3nd Number is the greatest among three");
            }
        }
    }

}
