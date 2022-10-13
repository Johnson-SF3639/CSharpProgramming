using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            int value;
            Console.Write($"Enter The Number : ");
            value = Convert.ToInt32(Console.ReadLine());

            PrimeNumber(value);

            void PrimeNumber(int value){
                int count=0;
                    for(int j=2; j<=value/2; j++){
                        count=0;
                        if(value%j == 0 ){
                            count++;
                        }
                    }
                    if(count <= 0 ){
                        Console.WriteLine($"{value} is Prime Number ");
                    }else{
                        Console.WriteLine($"{value} is Not Prime Number ");
                    }
                } 
        }
    }
}