using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            int value;
            string choice = "", pass;
            do{
                Console.WriteLine("Enter the Number ");
                value = Convert.ToInt32(Console.ReadLine());

                if(value%2 == 0){
                    Console.WriteLine("Even Number ");
                }else{
                    Console.WriteLine("Odd Number ");
                }
                Console.Write("Do you want try again : ");
                pass = Console.ReadLine();
                if(pass == "Yes"){
                    choice = "Yes";
                }
                if(pass == "No"){
                    choice = "No";
                }

            }while(choice == "Yes");
        }
    }
}