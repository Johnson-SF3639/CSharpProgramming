using System;
namespace DoWhileAssignment{
    class Program{
        public static void Main(string[] args)
        {
            int value;
            string choice = "", pass;
            bool check=true;
            do{
                Console.WriteLine("Enter the Number ");
                value = Convert.ToInt32(Console.ReadLine());

                if(value%2 == 0){
                    Console.WriteLine("Even Number ");
                }else{
                    Console.WriteLine("Odd Number ");
                }
                do{
                Console.Write("Do you want try again : ");
                pass = Console.ReadLine();
                if(pass == "Yes"){
                    choice = "Yes";
                    check = false;
                }
                else if(pass == "No"){
                    choice = "No";
                    check=false;
                }
                else{
                    check = true;
                }
                }while(check);

            }while(choice == "Yes");
        }
    }
}