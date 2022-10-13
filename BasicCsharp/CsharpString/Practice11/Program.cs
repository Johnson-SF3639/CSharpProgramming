using System;
namespace Practice11{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            bool check=true;

            Console.Write($"Enter The String : ");
            word = Console.ReadLine();

            Console.WriteLine($"After removing duplicates characters from the said string : ");
            for(int i=0; i<word.Length; i++){
                string a= word.Substring(i+1);
                check = a.Contains(word[i]);

                if(check == false){
                    Console.Write($"{word[i]}");
                }
            }
        }
    }
}