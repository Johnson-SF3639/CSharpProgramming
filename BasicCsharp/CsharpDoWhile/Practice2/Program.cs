using System;
namespace Practice2{
    class Program{
        public static void Main(string[] args)
        {
            int value, sum=0;
            string choice = "", pass;

            do{
                Console.WriteLine("Enter the Number ");
                value = Convert.ToInt32(Console.ReadLine());

                if(value>0){
                sum+=value;
                }

                Console.Write("Enter the Next Number (Yes/No) : ");
                pass = Console.ReadLine();

                if(pass == "Yes"){
                    choice = "Yes";
                }
                if(pass == "No"){
                    choice = "No";
                }
            }while(choice == "Yes");

            Console.Write($"Sum is {sum}");
        }
    }
}