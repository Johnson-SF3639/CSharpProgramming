using System;
namespace Practice3{
    class Program{
        public static void Main(string[] args)
        {
            int length, sum=0;
            int[] datas = new int[3];
            
            Console.Write("Input the number of elements to store in the array : ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 3 elements in the array:  ");
            for(int i=0; i<length; i++){
                Console.Write($"Element - {i} : ");
                datas[i] = Convert.ToInt32(Console.ReadLine());
                sum= sum + datas[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
        }
    }
}