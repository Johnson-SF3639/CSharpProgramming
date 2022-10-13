using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            Console.Write($"Enter The Sentance : ");
            word = Console.ReadLine();
            char[] spliter = word.ToCharArray();
            Console.WriteLine($"The characters of the string in reverse are: ");
            for(int i=spliter.Length-1; i>=0 ; i--){
                Console.Write($"{spliter[i]} ");
            }
        }
    }
}