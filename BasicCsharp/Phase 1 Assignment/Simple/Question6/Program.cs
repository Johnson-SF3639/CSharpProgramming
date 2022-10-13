using System;
namespace Question6{
    class Program{
        public static void Main(string[] args)
        {
            string passWord;
            Console.WriteLine($"Enter the Password : ");
            passWord =Console.ReadLine();

            if(passWord == "s3cr3t!P@ssw0rd"){
                Console.WriteLine($"Welcome");
            }else{
                Console.WriteLine($"Wrong Password");
            }
        }
    }
}