using System;
namespace FunctionDelegate{
    class Program{

        static double Sum(int a, int b){ return a+b; }
        static double Subtact(int a, int b){ return a-b; }
        static double Calculator (Func<int, int, double> operation, int x, int y){
            return operation(x,y);
        }   
        public static void Main(string[] args)
        {    
            Console.WriteLine(Calculator(Sum,10,20));
            Console.WriteLine(Calculator(Subtact,10,20));
                 
        }
    }
}