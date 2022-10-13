using System;
namespace Question10{
    class Program{
        public static void Main(string[] args)
        {
            char word;
            Console.WriteLine($"Enter the Word : ");
            word =Convert.ToChar(Console.ReadLine());

            if((word == 'a') || (word == 'e') || (word == 'i') || (word == 'o') || (word == 'u')){
                Console.WriteLine($"It is a vowel");
            }else{
                Console.WriteLine($"It is not a vowel");
            }
        }
    }
}