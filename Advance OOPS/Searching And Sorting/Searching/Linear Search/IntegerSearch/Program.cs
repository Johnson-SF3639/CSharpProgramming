using System;
namespace IntergerSearch
{
    class Program
    {
        public static void Main(string[] args)
        {
            //set array
            // int[] linearArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            
            //get Array
            Console.WriteLine($"Enter the Size Array :");
            int lenthArray = int.Parse(Console.ReadLine());
                        
            int[] linearArray = new int[lenthArray];
            Console.WriteLine($"Enter the Array elements :");
            for(int i=0; i < lenthArray ; i++){
                linearArray[i]=int.Parse(Console.ReadLine());
            }


            //get the search number
            Console.WriteLine($"Enter the Searching Number : ");
            int searchNumber = int.Parse(Console.ReadLine());

            //search the number
            int flag = 0, count = 0;
            foreach (int array in linearArray)
            {
                if (searchNumber == array)
                {
                    flag = 1;
                    break;
                }
                count++;
            }
            if (flag == 0)
            {
                Console.WriteLine($"Number is not Here");
            }
            else
            {
                Console.WriteLine($"Number is Founded and his Position is : {count}");
            }
        }
    }
}
