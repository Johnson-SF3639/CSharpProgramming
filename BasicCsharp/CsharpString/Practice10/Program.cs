using System;
namespace Practice10{
    class Program{
        public static void Main(string[] args)
        {
            string userName, passWord;

            Console.Write($"Enter The User Name : ");
            userName = Console.ReadLine();
            Console.Write($"Enter The Password: ");
            passWord = Console.ReadLine();

            if(userName == "User" && passWord == "Pass"){
            Console.WriteLine($"Password entered successfully");
            }else{
            Console.WriteLine($"Wrong Password");
            }
        }
    }
}