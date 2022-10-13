using System;
namespace Question1{
    class Program{
        public static void Main(string[] args)
        {
            int[,] array1 = new int[2,3];
            int[,] array2 = new int[3,2];
            int[,] array3 = new int[2,2];
            
            Console.WriteLine($"Enter the 1st Array");
            for(int i=0; i<2; i++){
                for(int j=0; j<3; j++){
                    array1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"Enter the 2st Array");
            for(int i=0; i<3; i++){
                for(int j=0; j<2; j++){
                    array2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine($"The 1st Array");
            for(int i=0; i<2; i++){
                for(int j=0; j<3; j++){
                   Console.Write($"{array1[i,j]} ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine($"The 2st Array");
            for(int i=0; i<3; i++){
                for(int j=0; j<2; j++){
                   Console.Write($"{array2[i,j]} ");
                }
                Console.WriteLine("");
            }
            
            Console.WriteLine($"Multiplication of Array");
            for(int i=0; i<2; i++){
                for(int j=0; j<2; j++){
                    array3[i,j]=0;
                    for(int k=0; k<3; k++){
                        array3[i,j]+=array1[i,k]*array2[k,j];
                    }
                }
            }
            
            for(int i=0; i<2; i++){
                for(int j=0; j<2; j++){
                   Console.Write($"{array3[i,j]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}