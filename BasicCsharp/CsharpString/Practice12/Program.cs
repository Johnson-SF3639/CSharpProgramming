using System;
using System.Linq;
namespace Practice12{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            int[] intString = new int[10];

            Console.Write($"Enter The String : ");
            word = Console.ReadLine();

            string[] spliter = word.Split(' ');

            Console.WriteLine($"Maximum and minimum number of the said string: ");
            Console.Write($"{spliter.Max()}, {spliter.Min()} ");
        }
    }
}