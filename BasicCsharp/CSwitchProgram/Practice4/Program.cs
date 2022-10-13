using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            int value1,value2;
            int action;
            Console.WriteLine("Enter the 1st Interger : ");
            value1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2st Interger : ");
            value2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here are the options :\n\n1-Addition\n2-Substraction\n3-Multiplication\n4-Division\n5-Exit\n");
            action= Convert.ToInt32(Console.ReadLine());
            switch(action){
                case 1: {
                    Console.WriteLine($"The Addition of {value1} and {value2} is "+ (value1+value2));
                    break;
                }
                case 2: {
                    Console.WriteLine($"The Substraction of {value1} and {value2} is "+ (value1-value2));
                    break;
                }
                case 3: {
                    Console.WriteLine($"The Multiplication of {value1} and {value2} is"+ (value1*value2));
                    break;
                }
                case 4: {
                    Console.WriteLine($"The Division of {value1} and {value2} is"+ (value1/value2));
                    break;
                }
                case 5: {
                    Console.WriteLine("Exit Sucessfully");
                    break;
                }
            }
        }
    }
}