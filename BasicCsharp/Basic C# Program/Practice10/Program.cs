using System;
namespace Practice10{
    class Program{
        public static void Main(string[] args)
        {
            int value1=15, value2=20;
            Console.WriteLine("a. "+(value1 > value2));
            Console.WriteLine("b. "+(value1 < value2));
            Console.WriteLine("c. "+(value1 >= value2));
            Console.WriteLine("d. "+(value1 ==value2));
            Console.WriteLine("e. "+(value1 != value2));
            Console.WriteLine("f. "+(value1 <= value2));
            Console.WriteLine("g. "+(value1 >= 10 && value2 >=10));
            Console.WriteLine("h. "+(value1 >= 10 || value2 >= 30));
            Console.WriteLine("i. "+!(value1>20));
            String value = (value1==15) ? "true" : "false";
            Console.WriteLine("j. "+value);
            Console.WriteLine("k. "+value1++);
            Console.WriteLine("l. "+value1--);
            
        }
    }
}
