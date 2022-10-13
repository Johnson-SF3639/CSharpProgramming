using System;
namespace Practice5{
    class Program{
        public static void Main(string[] args)
        {
            int length;
            // int[] datas = new int[5];
            
            Console.Write("Input the number of elements to stored in the array : ");
            length = Convert.ToInt32(Console.ReadLine());
            
            int[] datas = new int[length];

            Console.WriteLine("Input {length} elements in the array:  ");
            for(int i=0; i<length; i++){
                Console.Write($"Element - {i} : ");
                datas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"\nThe Even elements are: ");
            foreach(int value in datas){
                if(value%2 == 0){
                    Console.Write($"{value} ");
                }
            }
            Console.WriteLine($"\nThe Odd elements are: ");
            foreach(int value in datas){
                if(value%2 != 0){
                    Console.Write($"{value} ");
                }
            }
        }
    }
}