using System;
namespace Practice7{
    class Program{
        public static void Main(string[] args)
        {
            string customerName;
            double customerId, unit, amountUnit, charge, surchargeAmount=0, netAmount=0 ;

            Console.WriteLine("Enter You customerId :");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter You customerName :");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter You unit :");
            unit = Convert.ToInt32(Console.ReadLine());

            if(unit <= 199){
                charge=1.20;
                amountUnit=unit*charge;
            }else if(unit > 200 && unit < 400){
                charge=1.50;
                amountUnit=unit*charge;
            }else if(unit > 400 && unit < 600){
                charge=1.80;
                amountUnit=unit*charge;
            }else{
                charge=2;
                amountUnit=unit*charge;
            }

            if(amountUnit > 400){
                surchargeAmount= 0.15* amountUnit;
                netAmount=surchargeAmount+amountUnit;
            }
            
            Console.WriteLine($"Customer ID NO : {customerId}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"unit Consumed : {unit}");
            Console.WriteLine($"Surchage Amount : {surchargeAmount}");
            Console.WriteLine($"Amount Charges @Rs. {charge} per unit : {amountUnit}");
            Console.WriteLine($"Net Amount Paid By the Customer : {netAmount}");
        }
    }
}