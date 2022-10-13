using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            double chemistryMark, physicsMark, mathMark, sum, precentage;

            Console.WriteLine("Enter Physics Mark :");
            physicsMark= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Mark :");
            chemistryMark= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maths Mark :");
            mathMark= Convert.ToInt32(Console.ReadLine());
            
            sum=(mathMark + chemistryMark + physicsMark);

            precentage =(sum/300)*100;

            Console.WriteLine("Physics - " +physicsMark);
            Console.WriteLine("Chemistry - " +chemistryMark);
            Console.WriteLine("Maths - " +mathMark);
            Console.WriteLine("Sum - " +sum);
            Console.WriteLine("Precentage -" +precentage);
        }
    }
}
