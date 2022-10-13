using System;
namespace Practice7{
    class Program{
        public static void Main(string[] args)
        {            
            int[,] datas = new int[3,3];

            Console.WriteLine("Input elements in the matrix (3X3): ");
            for(int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                    Console.Write($"Element - [{i}],[{j}] : ");
                    datas[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The Matrix is :");
            for(int i=0; i<3; i++){
                for(int j=0; j<3; j++){
                    Console.Write($"{datas[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}