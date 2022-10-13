using System;
namespace Practice9{
    class Program{
        public static void Main(string[] args)
        {
            int armstrongNumber, length=0, enterance=1, temp, answer, ans=1, total=0;
            armstrongNumber = Convert.ToInt32(Console.ReadLine());
            temp = armstrongNumber;

            for(int i=0; enterance!=0; i++){
                enterance= temp/10;
                temp=enterance;
                length+=1;
            }
            
            temp = armstrongNumber;
            for(int i=0; i<length; i++){
                answer=temp%10;
                ans=1;
                for(int j=0; j<length; j++){
                    ans=ans*answer;
                }
                total+=ans;
                enterance= temp/10;
                temp=enterance;
            }
            
            if(total == armstrongNumber){
                Console.WriteLine($"{armstrongNumber} is an Armstrong number");
            }else{
                Console.WriteLine($"{armstrongNumber} is Not an Armstrong number");
            }
 

        }
    }
}