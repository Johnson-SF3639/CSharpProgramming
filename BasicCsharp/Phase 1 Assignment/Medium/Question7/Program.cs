using System;
namespace Question7{
    class Program{
        public static void Main(string[] args)
        {
            int start, difference, element, j=0,sum=0;
            
            Console.WriteLine($"Enter the Start No : ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the Difference No : ");
            difference = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Enter the Element No : ");
            element = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Series : ");
            for(int i=start; j!=10; i+=difference){
                Console.Write($"{i} ");
                sum+=i;
                j++;
            }
            Console.WriteLine($"\nSum is : {sum}");
        }
    }
}