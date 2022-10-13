using System;
namespace ForEachAssignment{
    class Program{
        public static void Main(string[] args)
        {
            int length,flag=0;
            string[] names = new string[5];
            string searchName;

            Console.WriteLine("Enter the Array Size : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Names : ");
            for(int i=0; i<length; i++){
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("List of Names in this Array : ");
            for(int i=0; i<length; i++){
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("Enter the Name to Search : ");
            searchName = Console.ReadLine();

            for(int i=0; i<length; i++){
                if(searchName == names[i]){     
                    Console.WriteLine($"{searchName} Name is present in array and Index poision is {i}");
                    flag =1;
                }
            }
            if(flag!=1){
                Console.WriteLine("The name is not present in array (For loop)" );
            }

            foreach(string name in names){
                if(searchName == name){
                    Console.WriteLine($"{searchName} Name is present in array");
                    flag =1;
                }
            }
            if(flag!=1){
                Console.WriteLine("The name is not present in array (ForEach Loop)" );
            }
        }
    }
}