
using System;
namespace Practice6{
    class Program{
        public static void Main(string[] args)
        {
            int length, temp;
            // int[] datas = new int[5];
            
            Console.Write("Input the number of elements to stored in the array : ");
            length = Convert.ToInt32(Console.ReadLine());
            
            int[] datas = new int[length];

            Console.WriteLine($"Input {length} elements in the array:  ");
            for(int i=0; i<length; i++){
                Console.Write($"Element - {i} : ");
                datas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<length; i++){
                for(int j=i+1; j<length; j++){
                    if(datas[i]>datas[j]){
                        temp = datas[i];
                        datas[i]= datas[j];
                        datas[j]=temp;
                    }
                }
            }
            foreach(int list in datas){
                Console.Write($"{list} ");
            }
        }
    }
}