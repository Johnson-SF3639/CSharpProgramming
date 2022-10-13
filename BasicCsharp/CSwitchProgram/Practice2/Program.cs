using System;
namespace Practice2{
    class Program{
        public static void Main(string[] args)
        {
            int action;
            Console.WriteLine("Enter the Grade\n\n 1 = MonDay\n 2 = Tuesday\n 3 = Wednesday \n 4 = Thursday\n 5 = Friday\n 6 = Saturday\n 7 = Sunday\n");
            action= Convert.ToInt32(Console.ReadLine());
            switch(action){
                case 1: {
                    Console.WriteLine("Monday");
                    break;
                }
                case 2: {
                    Console.WriteLine("Tuesday");
                    break;
                }
                case 3: {
                    Console.WriteLine("Wednesday");
                    break;
                }
                case 4: {
                    Console.WriteLine("Thursday");
                    break;
                }
                case 5: {
                    Console.WriteLine("Friday");
                    break;
                }
                case 6: {
                    Console.WriteLine("Saturday");
                    break;
                }
                case 7: {
                    Console.WriteLine("Sunday");
                    break;
                }
            }
        }
    }
}