using System;
namespace Practice2{
    class Program{
        public static void Main(string[] args)
        {
            int length;
            string[] datas = new string[3];

            Console.Write("Input the number of elements to store in the array : ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input {length} number of elements in the array : ");
            for(int i=0; i<3; i++){
                Console.Write($"Element - {i} : ");
                datas[i] = Console.ReadLine();
            }
            Console.WriteLine("The values store into the array are : ");
            for(int i=0; i<3; i++){
                Console.Write($"{datas[i]} ");
            }
            Console.WriteLine("\nThe values store into the array in reverse are : ");
            for(int i=(3-1); i>=0; i--){
                Console.Write($"{datas[i]} ");
            }
        }
    }
}