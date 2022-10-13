using System;
namespace Question9{
    class Program{
        public static void Main(string[] args)
        {
            string month;
            int numberofleave, salary;
            Console.WriteLine($"Enter the Month : ");
            month =Console.ReadLine();
            Console.WriteLine($"Enter the Number of Leave : ");
            numberofleave =Convert.ToInt32(Console.ReadLine());

            if((month == "Jan") || (month == "Mar") || (month == "May") || (month == "Jul") || (month == "Aug") || (month == "Oct") || (month == "Dec")){
                salary = (31-numberofleave)*500;
                Console.WriteLine($"Amount of Salary is : {salary}");
            }else if((month == "Apr") || (month == "Jun") || (month == "Sep") || (month == "Nov")){
                salary = (31-numberofleave)*500;
                Console.WriteLine($"Amount of Salary is : {salary} ");
            }else{
                salary = (29-numberofleave)*500;
                Console.WriteLine($"Amount of Salary is : {salary} ");
            }
        }
    }
}