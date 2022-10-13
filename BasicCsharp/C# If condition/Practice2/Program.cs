using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter You Age :");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>=18){
                Console.WriteLine("Congratulation!You are eligible for casting your vote.");                
            }else{
                Console.WriteLine("Not Eligible");
            }
            
        }
    }
}