using System;
namespace Question8{
    class Program{
        public static void Main(string[] args)
        {
            string word;
            int sum=0;
            Console.WriteLine($"Enter the String : ");
            word = Console.ReadLine();
            for(int i=0; i<word.Length; i++){
                if(word[i] <= '0' || word[i] >='9'){
                    continue;
                }else{
                    sum=sum+word[i];
                    Console.Write($"{word[i]}");
                }
            }
            if(sum%2==0){
            Console.WriteLine($" is Even Number ");
            }else{
            Console.WriteLine($" is Odd Number ");
            }
        
        }
    }
}