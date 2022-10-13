using System;
namespace ListDS{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine($"\n***** Add  Capacity *****");
            
            Lists<int> data = new Lists<int>();

            data.Add(1);
            data.Add(2);
            data.Add(3);
            data.Add(4);
            data.Add(5);
            data.Add(6);
            
            for(int i=0; i<data.Capacity; i++){
                Console.Write($"{data[i]} ");
            }

            Console.WriteLine($"\nInsert.......3rd Positoin La 5");

            data.Insert(3,5);
            

            Console.WriteLine($"For Method.......");

            for(int i=0; i<data.Capacity; i++){
                Console.Write($"{data[i]} ");
            }

            Console.WriteLine($"\nForeach Method.......");

            foreach(int value in data){
                Console.Write($"{value} ");
            }

            Console.WriteLine($"\nRemove At.......");

            data.RemoveAt(3);

            foreach(int value in data){
                Console.Write($"{value} ");
            }

            Console.WriteLine($"\nRemove.......");
            
            data.Remove(5);

            foreach(int value in data){
                Console.Write($"{value} ");
            }

            Console.WriteLine($"\nRemove Extra.......");
            
            data.RemoveExtr(10);

            foreach(int value in data){
                Console.Write($"{value} ");
            }


            // Console.WriteLine($"\nArray Capacity : {data.Capacity}");
            // Console.WriteLine($"Array Count : {data.Count}");
            Console.WriteLine($"\n*************************");
            
        }
    }
}