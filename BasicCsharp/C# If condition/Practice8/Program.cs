using System;
namespace Practice8{
    class Program{
        public static void Main(string[] args)
        {
            int sugerLevel;
            Console.WriteLine("Enter You sugerLevel :");
            sugerLevel = Convert.ToInt32(Console.ReadLine());
            if(sugerLevel <= 90){
                Console.WriteLine("Low sugar");                
            }else if(sugerLevel >90 && sugerLevel <= 130) {
                Console.WriteLine("Normal");
            }else if(sugerLevel >130 && sugerLevel <= 140) {
                Console.WriteLine("Medium");
            }else if(sugerLevel >140 && sugerLevel <= 170) {
                Console.WriteLine("high sugar – try to reduce it from now");
            }else{
                Console.WriteLine("You are a very high Sugar Patient");
            }
            
        }
    }
}