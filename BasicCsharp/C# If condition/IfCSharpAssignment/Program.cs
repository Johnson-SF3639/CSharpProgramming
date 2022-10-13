using System;
namespace IfCSharpAssignment{
    class Program{
        public static void Main(string[] args)
        {
            char action;
            int value1, value2;
            Console.WriteLine("Enter the Value 1");
            value1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value 2");
            value2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Any Operator from +, -, *, /, %");
            action= Convert.ToChar(Console.ReadLine());
            switch(action){
                case '+': {
                    Console.WriteLine($"{value1} + {value2} = "+(value1+value2));
                    break;
                }
                case '-': {
                    Console.WriteLine($"{value1} - {value2} = "+(value1-value2));
                    break;
                }
                case '*': {
                    Console.WriteLine($"{value1} * {value2} = "+(value1*value2));
                    break;
                }
                case '/': {
                    Console.WriteLine($"{value1} / {value2} = "+(value1/value2));
                    break;
                }
                case '%': {
                    Console.WriteLine($"{value1} % {value2} = "+(value1%value2));
                    break;
                }
            }
        }
    }
}