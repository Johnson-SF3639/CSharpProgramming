using System;
namespace Practice10{
    class Program{
        public static void Main(string[] args)
        {
            double number, count=0;
            Console.Write("Enter the Number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i=2; i<= number; i++){
                if(number%i == 0 ){
                    count+=1;
                }
            }
            if(number == 1){
                Console.WriteLine($"{number} is Prime Number ");
            }if(count == 1){
                Console.WriteLine($"{number} is Prime Number ");
            }else{
                Console.WriteLine($"{number} is Not Prime Number ");
            }
            
        }
    }
}