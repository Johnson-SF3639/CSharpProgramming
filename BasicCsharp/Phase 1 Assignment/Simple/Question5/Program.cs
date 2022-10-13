using System;
namespace Question5{
    class Program{
        public static void Main(string[] args)
        {
            double salary, basic=10000, da=10, hra=10, tax=5;
            da = (basic/10);
            hra = (basic/10);
            tax = ((basic/10)/2);
            salary = basic+da+hra-tax;

            Console.WriteLine($"Salary : {salary}");
        }
    }
}