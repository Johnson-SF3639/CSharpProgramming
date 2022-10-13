using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word1, word2;
            bool pass = true;
            Console.WriteLine($"Entert the 1st Word : ");
            word1 = Console.ReadLine();
            Console.WriteLine($"Entert the 2st Word : ");
            word2 = Console.ReadLine();

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    pass = word1.Contains(word2[i]);
                    if (pass == false)
                    {
                        Console.WriteLine($"Name one and two are Not Anagrams");
                        break;
                    }
                }
            }
            if (word1.Length != word2.Length)
            {                
                Console.WriteLine($"Name one and two are Not Anagrams");
            }
            else if(pass == true)
            {
                Console.WriteLine($"Name one and two are Anagrams");
            }
        }
    }
}