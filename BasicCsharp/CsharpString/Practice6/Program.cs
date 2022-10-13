using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            int digits=0, alphabets=0, specialCharacters=0;

            Console.Write($"Enter The 1st Sentance  : ");
            word = Console.ReadLine();

            char[] spliter = word.ToCharArray();
            
            for(int i=0; i<word.Length; i++){
                if((spliter[i]>='a' && spliter[i]<='z')||(spliter[i]>='A' && spliter[i]<='Z')){
                    alphabets++;
                }else if(spliter[i]>='0' && spliter[i]<='9'){
                    digits++;
                }else{
                    specialCharacters++;
                }
            }
            Console.WriteLine($"Number of Alphabets in the string is : {alphabets}");
            Console.WriteLine($"Number of Digits in the string is :  {digits}");
            Console.WriteLine($"Number of Special characters in the string is : {specialCharacters}");


        }
    }
}