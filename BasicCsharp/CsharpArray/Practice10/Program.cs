using System;
namespace Practice10{
    class Program{
        public static void Main(string[] args){

            int row, columns;

            Console.WriteLine("Input the size of the Transpose matrix (less than 5): ");
            Console.Write("Enter The Number of Rows ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Number of Columns  ");
            columns = Convert.ToInt32(Console.ReadLine());

            int[,] datas1 = new int[row, columns];
            int[,] datas2 = new int[row, columns];

            Console.WriteLine("Input elements in the matrix :): ");
            for (int i = 0; i < row; i++){
                for (int j = 0; j < columns; j++){
                    Console.Write($"Element - [{i}],[{j}] : ");
                    datas1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The First Matrix is :");
            for (int i = 0; i < row; i++){
                for (int j = 0; j < columns; j++){
                    Console.Write($"{datas1[i, j]} ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++){
                for (int j = 0; j < columns; j++){
                    datas2[j, i] = datas1[i, j];
                }
            }

            Console.WriteLine("The Transpose of a matrix is : ");
            for (int i = 0; i < columns; i++){
                for (int j = 0; j < row; j++){
                    Console.Write($"{datas2[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}