using System;
namespace Practice8{
    class Program{
        public static void Main(string[] args)
        {
            int value, total, mark1, mark2, mark3;
            double percentage;
 
            total = totalmark();
            Console.WriteLine("Percentage : "+Percentage(total));
        
            int totalmark(){
                Console.WriteLine("Enter The 1st Number : ");
                mark1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The 2nd Number : ");
                mark2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The 3nd Number : ");
                mark3 = Convert.ToInt32(Console.ReadLine());
                return (mark1+mark2+mark3);
            } 
            double Percentage(int total){
                Console.WriteLine($"Mark 1 is : {mark1}\nMark 2 is : {mark2}\nMark 3 is : {mark3}\n");
                percentage = (double)total/300*100;
                return (percentage);
            }

        }
    }
}