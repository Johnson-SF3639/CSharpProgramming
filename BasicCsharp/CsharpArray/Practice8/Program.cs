using System;
namespace Practice8{
    class Program{
        public static void Main(string[] args)
        {            
            int row, columns;            

            Console.WriteLine("Input the size of the square matrix (less than 5): ");
            Console.Write("Enter The Number of Rows ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Number of Columns  ");
            columns = Convert.ToInt32(Console.ReadLine());

            int[,] datas1 = new int[row,columns];
            int[,] datas2 = new int[row,columns];
            int[,] total = new int[row,columns];

            Console.WriteLine("Input elements in the First matrix :): ");
            for(int i=0; i<row; i++){
                for(int j=0; j<columns; j++){
                    Console.Write($"Element - [{i}],[{j}] : ");
                    datas1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Input elements in the Second matrix :): ");
            for(int i=0; i<row; i++){
                for(int j=0; j<columns; j++){
                    Console.Write($"Element - [{i}],[{j}] : ");
                    datas2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The First Matrix is :");
            for(int i=0; i<row; i++){
                for(int j=0; j<columns; j++){
                    Console.Write($"{datas1[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Second Matrix is :");
            for(int i=0; i<row; i++){
                for(int j=0; j<columns; j++){
                    Console.Write($"{datas2[i,j]} ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("The Addition of two matrix is ");
            for(int i=0; i<row; i++){
                for(int j=0; j<columns; j++){
                    total[i,j] = datas1[i,j]+datas2[i,j];
                    Console.Write($"{total[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}