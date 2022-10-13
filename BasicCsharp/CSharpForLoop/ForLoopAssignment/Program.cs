using System;
namespace ForLoopAssignment{
    class Program{
        public static void Main(string[] args)
        {
            int value1, value2, answer=0;
            for(int i=0; i<=25; i++){
                if(i%2==0){
                    Console.WriteLine($"{i} is Even Number");                    
                }
            }

            Console.WriteLine("Enter the 1st Number : "); 
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2st Number : "); 
            value2 = Convert.ToInt32(Console.ReadLine());
            for(int i=value1; i<=value2; i++){
                answer=answer+(i*i);
            }
            Console.WriteLine(answer); 
        }
    }
}