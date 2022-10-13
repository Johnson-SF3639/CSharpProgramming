using System;
namespace Question4{
    class Program{
        public static void Main(string[] args)
        {
            int lowLimit, upLimit, temp, mod;
            double total=0, length;
            Console.Write($"Enter the Low Limit: ");
            lowLimit =Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the Up Limit: ");
            upLimit =Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Armstrong number between {lowLimit} to {upLimit} are:");
            for(int i=lowLimit; i<=upLimit; i++){
                total=0; length=0;
                temp=i;
                while(temp !=0){
                    temp = temp/10;
                    length++;
                }
                temp=i;
                while(temp != 0){
                    mod=temp%10;
                    total=total+Math.Pow(mod,length);
                    temp=temp/10;
                }
                if(i == total){
                    Console.Write($"{total} ");
                }
            }
        }
    }
}