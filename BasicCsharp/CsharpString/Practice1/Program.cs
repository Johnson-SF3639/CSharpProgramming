using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write($"Enter The Sentance : ");
            string word = Console.ReadLine();
            Console.WriteLine($"{word.Length}");
        }
    }
}