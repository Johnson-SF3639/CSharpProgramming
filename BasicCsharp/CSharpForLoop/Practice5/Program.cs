using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            double value, count=0, sum=0;
            Console.Write("Enter the Terms : ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are : ");
            for(int i=1; ; i++){
                if(i%2==1){
                    count+=1;
                    Console.Write($"{i} ");
                    sum+=i;
                    if(count >= value){
                        break;
                    }
                }
            }
            Console.WriteLine($"\nThe Sum of odd Natural Number upto {value} terms : {sum}");              
        }
    }
}