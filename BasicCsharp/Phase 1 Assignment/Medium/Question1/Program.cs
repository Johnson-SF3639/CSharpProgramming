using System;
namespace Question1{
    class Program{
        public static void Main(string[] args)
        {
            double basic, answer,salary, tax, insurance;
            Console.WriteLine($"Enter the Basic Salary");
            basic = Convert.ToInt32(Console.ReadLine());

            if(basic <= 10000){   
                answer= LowSalary(basic);
            }else if(basic <= 20000){
                answer= AverageSalary(basic);
            }else{
                answer= HighSalary(basic);
            }
            
            Console.WriteLine("Annual Gross "+salary*12);
            tax= ((double)6/12)*salary;
            insurance = ((double)1/12)*salary;
            answer = answer - tax - insurance;
            Console.WriteLine($"Take home salary is : {answer}");


            double LowSalary(double basic){
                salary= basic + ((double)20/100*basic) + ((double)80/100*basic) ;
                return(salary);
            }
            double AverageSalary(double basic){
                salary= basic+ ((double)25/100*basic) + ((double)90/100*basic) ;
                return(salary);
            }
            double HighSalary(double basic){
                salary= basic+ (((double)30/100)*basic) + (((double)95/100)*basic) ;
                return(salary);
            }
        }
    }
}