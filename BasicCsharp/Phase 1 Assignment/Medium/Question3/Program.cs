using System;
namespace Question3{
    class Program{
        public static void Main(string[] args)
        {
            int value, remember, mod, number=0;
            Console.Write($"Enter the Number: ");
            value =Convert.ToInt32(Console.ReadLine());
            remember = value;
            while(remember != 0){
                mod=remember%10;
                number = (number*10)+mod;
                remember=remember/10;
            }  
            if(number == value){
                Console.WriteLine($"{value} is palindrome");                
            }else{
                Console.WriteLine($"{value} is Not palindrome");                
            }
        }
    }
}