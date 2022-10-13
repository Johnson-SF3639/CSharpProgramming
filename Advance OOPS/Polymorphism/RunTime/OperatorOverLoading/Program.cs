using System;
namespace OreratorOverLoading{
    class Program{


        public static void Main(string[] args)
        {
            Console.WriteLine($"\n***** Operation Over Loading *****\n");
            
            Box box1 = new Box(2.0, 3.0, 4.0);
            Box box2 = new Box(20.0, 30.0, 4.0);
            Box box3;

            //Obj 1
            double volume = box1.Calculate();
            Console.WriteLine($"Volume of Box 1 : {volume}");

            //Obj 2
            volume = box2.Calculate();
            Console.WriteLine($"Volume of Box 2 : {volume}");

            //Obj 3
            box3 = box1 + box2;
            volume = box3.Calculate();
            Console.WriteLine($"Volume of Box 3 : {volume}");

        Console.WriteLine($"\n");
        
        }
    }
}