using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            string word1, word2, check="True";
            int length1, length2, breaker=0;
            Console.Write($"Enter The 1st Sentance  : ");
            word1 = Console.ReadLine();
            Console.Write($"Enter The 2nd Sentance : ");
            word2 = Console.ReadLine();

            length1 = word1.Length; 
            length2 = word2.Length; 

            char[] spliter1 = word1.ToCharArray();
            
            char[] spliter2 = word2.ToCharArray();

            for(int i=0; i < length1; i++){
                    if(spliter1[i]!= spliter2[i]){
                        check="False";
                        breaker+=1;
                    }
            }

            if(check=="True" && length1 == length2){
                Console.Write($"The length of both strings are equal and also, both strings are equal");
            }else if(check=="False" && length1 == length2){
                Console.Write($"The length of both strings are Equal and also, both strings are  Not Equal");
            }else{
                Console.Write($"The length of both strings are Not Equal and also, both strings are Not equal");
            }
        }
    }
}