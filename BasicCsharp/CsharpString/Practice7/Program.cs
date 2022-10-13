using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            int consonant=0, vowel=0;

            Console.Write($"Enter The 1st Sentance  : ");
            word = Console.ReadLine();
            
            for(int i=0; i<word.Length; i++){
                if(word[i]=='a'||word[i]=='e'||word[i]=='i'||word[i]=='o'|| word[i]=='u'){
                    vowel++;
                }else if(word[i]==' '||word[i]=='.'||word[i]<='@'||word[i]==','|| word[i]=='$'){
                    continue;
                }else{
                    consonant++;
                }
            }
            Console.WriteLine($"The total number of vowel in the string is : {vowel}");
            Console.WriteLine($"The total number of consonant in the string is : {consonant}");
        }
    }
}