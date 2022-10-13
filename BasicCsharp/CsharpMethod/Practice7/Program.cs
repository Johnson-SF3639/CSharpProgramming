using System;
namespace Practice7{
    class Program{
        public static void Main(string[] args)
        {
            string check;
            bool pass;
            Console.Write($"Enter The String : ");
            check = Console.ReadLine();

            pass = Palindrome(check);

            if(pass){
                Console.WriteLine("The string is Palindrome");
            }else{
                Console.WriteLine("The string is Not Palindrome");
            }

            bool Palindrome(string value){
                if(value.Length == 1){
                    return true;
                }
                if(value[0]!=value[value.Length-1]){
                    return false;
                }else{
                    return Palindrome(value.Substring(1,value.Length-2));
                }
            } 
        }
    }
}