using System;
namespace Practice4{
    class Program{
        public static void Main(string[] args)
        {
            int length, temp;
            
            Console.Write("Input the number of elements to store in the array : ");
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

            for(int i=0; i<length; i++){
                Console.WriteLine($"Element - {i} : "+datas[i]);
            }
                Console.WriteLine($"Maximum element is : {datas[length-1]}");
                Console.WriteLine($"Manimum element is : {datas[0]}");
        }
    }
}