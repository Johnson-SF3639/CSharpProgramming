using System;
namespace Practice2{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            Console.Write($"Enter The Sentance : ");
            word = Console.ReadLine();
            char[] spliter = word.ToCharArray();
            Console.WriteLine($"The characters of the string are : ");
            foreach(char i in spliter){
                Console.Write($"{i} ");
            }
        }
    }
}