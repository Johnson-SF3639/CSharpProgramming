using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            int value=1, value2, count=0;

            while(value <= 100){
                if(value%2 != 0){
                    Console.WriteLine($"Odd Number : {value}");
                }
                value++;
            }
            value=1;

            while(value <= 100){
                if(value%2 != 0){
                    Console.WriteLine($"Even Number : {value}");
                }
                value++;
            }
            
            value=2; value2=2;
            while(value<=100){
                count=0;
                while(value2 <= value/2){
                    if(value%value2 == 0 ){
                        count++;
                    }
                    value2++;
                }
                if(count == 0 ){
                    Console.WriteLine($"{value} is Prime Number ");
                }
                value++;
            }

        }
    }
}