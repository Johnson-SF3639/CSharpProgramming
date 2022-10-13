using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            int number=0, length=0;

            Console.Write($"Enter The 1st Sentance  : ");
            word = Console.ReadLine();
            Console.Write($"Enter The Starting Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter The Substring Length :");
            length = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"The substring retrieve from the string is : ");
            for(int i=number; i<(length+number); i++){
                Console.Write(word[i]);
            }
        }
    }
}