using System;
namespace Practice10{
    class Program{
        public static void Main(string[] args)
        {
            string passWord;

            Console.WriteLine("Enter You PassWord :");
            passWord = Console.ReadLine();

            if(passWord == "HiTeam"){
                Console.WriteLine("Right password");  
            }else{
                Console.WriteLine("Wrong password");
            }
        }
    }
}