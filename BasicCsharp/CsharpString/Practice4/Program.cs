using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            Console.Write($"Enter The Sentance : ");
            word = Console.ReadLine();

            string[] spliter = word.Split(new string[]{" "}, StringSplitOptions.None);

            Console.WriteLine($"Total number of words in the string is : "+spliter.Length);
        }
    }
}