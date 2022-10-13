using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            string action;
            Console.WriteLine("List of Countries\nIndia\nPakistan\nBangladesh\n");
            Console.WriteLine("Enter the Country Name : ");
            action= Console.ReadLine();
            switch(action){
                case "India": {
                    Console.WriteLine("1.Gambir \n2.Ashwin \n3.Dhoni \n4.Jadeja \n");
                    break;
                }
                case "Pakistan": {
                    
                    Console.WriteLine("1.John \n2.Siva \n3.Tamil \n4.Sethu \n");
                    break;
                }
                case "Bangladesh": {
                    
                    Console.WriteLine("1.Kemil \n2.Ram \n3.Aari \n4.Prabhu \n");
                    break;
                }
            }
        }
    }
}