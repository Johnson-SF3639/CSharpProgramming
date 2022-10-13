using System;
namespace Question15{
    class Program{
        public static void Main(string[] args)
        {
            int value1,count=0;
            Console.WriteLine($"Enter the Number : ");
            value1 =Convert.ToInt32(Console.ReadLine());

            for(int i=2; i<=value1/2; i++){
                if(value1%i==0){
                    count+=1;
                }      
            }
            if(count==0){
                Console.Write($"It is prime number");  
            }else{
                Console.Write($"It is Not prime number"); 
            }
            
        }
    }
}