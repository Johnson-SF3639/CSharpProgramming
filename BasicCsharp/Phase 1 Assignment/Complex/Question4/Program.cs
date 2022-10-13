using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word, subStr="";
            word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for(int j=i+1; j<word.Length; j++){
                    if(word[i]!=word[j]){
                        bool pass= subStr.Contains(word[i]);
                        if(pass == false){
                            subStr +=word[i];
                        }
                    }
                }
            }  
            Console.WriteLine($"{subStr}"); 
        }
    }
}