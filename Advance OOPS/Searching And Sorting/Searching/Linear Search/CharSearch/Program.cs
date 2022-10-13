using System;
namespace CharSearch{
    class Program{
        public static void Main(string[] args)
        {
            //set array
            // char[] linearArray = { 'a','b','c','d','s','y'};

            
            //get Array
            Console.WriteLine($"Enter the Size Array :");
            int lenthArray = int.Parse(Console.ReadLine());
                        
            char[] linearArray = new char[lenthArray];
            Console.WriteLine($"Enter the Array elements :");
            for(int i=0; i < lenthArray ; i++){
                linearArray[i]=char.Parse(Console.ReadLine());
            }

            //get the search number
            Console.WriteLine($"Enter the Searching Letter : ");
            char searchChar = char.Parse(Console.ReadLine());

            //search the number
            int flag = 0, count = 0;
            foreach (char array in linearArray)
            {
                if (searchChar == array)
                {
                    flag = 1;
                    break;
                }
                count++;
            }
            if (flag == 0)
            {
                Console.WriteLine($"Letter is Not Here");
            }
            else
            {
                Console.WriteLine($"Letter is Founded and his Position is : {count}");
            }
        }
    }
}