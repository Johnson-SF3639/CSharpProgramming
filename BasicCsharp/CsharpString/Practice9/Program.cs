using System;
namespace Practice9{
    class Program{
        public static void Main(string[] args)
        {
            string word, subStr;

            Console.Write($"Enter The Sentance  : ");
            word = Console.ReadLine();
            Console.Write($"Enter The Substring to search : ");
            subStr = Console.ReadLine();

            bool check = word.Contains(subStr);

            if(check == true){
            Console.WriteLine($"The substring exists in the string");
            }else{
            Console.WriteLine($"The substring Not in the string");
            }
        }
    }
}