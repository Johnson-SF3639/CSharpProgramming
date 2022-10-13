using System;
namespace Practice7{
    class Program{
        public static void Main(string[] args)
        {
            double a,b,answer;

            Console.WriteLine("Enter A :");
            a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B :");
            b= Convert.ToInt32(Console.ReadLine());

            answer =Math.Pow(a,2)+2*(a*b)+Math.Pow(b,2);

            Console.WriteLine(answer);
        }
    }
}
