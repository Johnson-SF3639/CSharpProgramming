using System;
namespace StringSearch{
    class Program{
        public static void Main(string[] args)
        {
            //set array
            // string[] linearArray = { "John", "Siva", "Tamil", "Sethu" };
            
            //get Array
            Console.WriteLine($"Enter the Size Array :");
            int lenthArray = int.Parse(Console.ReadLine());
                        
            string[] linearArray = new string[lenthArray];
            Console.WriteLine($"Enter the Array elements :");
            for(int i=0; i < lenthArray ; i++){
                linearArray[i]=Console.ReadLine();
            }

            //get the search number
            Console.WriteLine($"Enter the Searching Word : ");
            string searchString = Console.ReadLine();

            //search the number
            int flag = 0, count = 0;
            foreach (string array in linearArray)
            {
                if (searchString == array)
                {
                    flag = 1;
                    break;
                }
                count++;
            }
            if (flag == 0)
            {
                Console.WriteLine($"Word is Not Here");
            }
            else
            {
                Console.WriteLine($"Word is Founded and his Position is : {count}");
            }
        }
    }
}