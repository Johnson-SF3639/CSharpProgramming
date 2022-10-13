using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            
            double chemistryMark, physicsMark, mathMark, percentage;

            Console.WriteLine("Enter Chemistry Mark :");
            chemistryMark= Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Physics Mark :");
            physicsMark= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maths Mark :");
            mathMark= Convert.ToInt32(Console.ReadLine());

            percentage = ((mathMark+physicsMark+chemistryMark)/300)*100;

            if(percentage < 75){
                Console.WriteLine("The candidate is Not eligible for admission");
            }else{
                Console.WriteLine("The candidate is eligible for admission");
            }



        }
    }
}