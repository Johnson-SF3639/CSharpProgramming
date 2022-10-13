using System;
namespace Practice13{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            int count=0;

            Console.Write($"Enter The String : ");
            word = Console.ReadLine();

            for(int i=0; i<word.Length; i++){
                if(word[i] >= '0' && word[i] <= '9'){
                    count=count+word[i]-'0';
                }
            } 
             
            Console.Write($"{count} ");
        }
    }
}