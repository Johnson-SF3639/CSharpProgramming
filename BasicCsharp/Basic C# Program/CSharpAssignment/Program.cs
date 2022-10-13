using System;
namespace CSharpAssignment{
    class Program{
        public static void Main(string[] args)
        {
           int mark;
           Console.WriteLine("Enter the Mark : ");
           mark =Convert.ToInt32(Console.ReadLine());

           if(mark >= 80 && mark <= 100){
            Console.WriteLine("Grade B");
           }
           else if(mark >= 60 && mark < 80){
            Console.WriteLine("Grade C");
           }
           else if(mark >= 35 && mark < 60){
            Console.WriteLine("Grade D");
           }
           else{
            Console.WriteLine("Invalid input");
           }

        }
    }
}