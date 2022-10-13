using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            int action;
            Console.WriteLine("Enter the Grade\n\n 1 = January\n 2 = February\n 3 = March \n 4 = April\n 5 = May\n 6 = June\n 7 = July\n 8 = August \n 9 = September\n 10 = October\n 11 = November\n 12 = December\n");
            action= Convert.ToInt32(Console.ReadLine());
            switch(action){
                case 1: {
                    Console.WriteLine(31);
                    break;
                }
                case 2: {
                    Console.WriteLine(28);
                    break;
                }
                case 3: {
                    Console.WriteLine(31);
                    break;
                }
                case 4: {
                    Console.WriteLine(30);
                    break;
                }
                case 5: {
                    Console.WriteLine(31);
                    break;
                }
                case 6: {
                    Console.WriteLine(30);
                    break;
                }
                case 7: {
                    Console.WriteLine(31);
                    break;
                }
                case 8: {
                    Console.WriteLine(31);
                    break;
                }
                case 9: {
                    Console.WriteLine(30);
                    break;
                }
                case 10: {
                    Console.WriteLine(31);
                    break;
                }
                case 11: {
                    Console.WriteLine(30);
                    break;
                }
                case 12: {
                    Console.WriteLine(31);
                    break;
                }
            }
        }
    }
}