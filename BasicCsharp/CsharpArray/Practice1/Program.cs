using System;
namespace Practice1{
    class Program{
        public static void Main(string[] args)
        {
            string[] datas = new string[10];
            Console.WriteLine("Input 10 elements in the array:  ");
            for(int i=0; i<10; i++){
                Console.Write($"Element - {i} : ");
                datas[i] = Console.ReadLine();
            }
            Console.WriteLine("Elements in array are:  ");
            for(int i=0; i<10; i++){
                Console.Write($"{datas[i]} ");
            }
        }
    }
}