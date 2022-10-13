using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word;
            int count = 0, flag = 0;
            word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = (word.Length - i - 1); j >= 0; j++)
                {
                    if (word[i] == word[j])
                    {
                        count += 1;
                        break;
                    }
                    break;
                }
                if (count == word.Length)
                {
                    flag = 1;
                }
            }
            if (flag == 1)
            {
                flag = 1;
                Console.WriteLine($" {word} is a palindrome");
            }
            else
            {
                Console.WriteLine($" {word} is not a palindrome");
            }
        }
    }
}