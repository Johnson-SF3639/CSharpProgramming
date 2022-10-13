using System;
namespace Sorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 18, 19, 1, 5, 7, 3, 20 };
            string choose = "Yes";
            do
            {
                Console.WriteLine($"\n\nEnter your Option\n1. Bubble Sort\n2. Insertion Sort\n3. Selection Sort\n4. Merge Sort\n5. Quick Sort\n6. Exit");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine($"\nBubble Sort");
                            int[] sortArray = BubbleSort(intArray);
                            Console.WriteLine($"Sorted Array with Bubble Sort");
                            Display(sortArray);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"\nInsertion Sort");
                            int[] sortArray = InsertionSort(intArray);
                            Console.WriteLine($"Sorted Array with Insertion Sort");
                            Display(sortArray);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"\nSelection Sort");
                            int[] sortArray = SelectionSort(intArray);
                            Console.WriteLine($"Sorted Array with Selection Sort");
                            Display(sortArray);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"\nMerge Sort");
                            Console.WriteLine($"Sorted Array with Merge Sort");
                            MergeSort(intArray, 0, intArray.Length);
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            choose = "No";
                            break;
                        }
                }
            } while (choose == "Yes");
        }

        public static void Display(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }

        public static int[] BubbleSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    //Checking
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            int min, temp;
            for (int i = 0; i < array.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            int temp = 0;
            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                int j = i - 1;
                while ((j <= 0) && (temp <= array[j]))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }

        public static void MergeSort(int[] array, int start, int end)
        {
            int[] mergeSortArray = new int[array.Length];
            int mid, i, j, k;
            if (start < end)
            {
                mid = (start + end) / 2;
                MergeSort(array, start, mid);
                MergeSort(array, mid + 1, end);

                i = start; j = mid - 1; k = start;

                while ( i <= mid && j <= end)
                {
                    if (array[i] <= array[j])
                    {
                        mergeSortArray[k] = array[i];
                        i++;
                    }
                    else
                    {
                        mergeSortArray[k] = array[j];
                        j++;
                    }
                    k++;
                }
                if (i > mid){
                    while (j <= end){
                        mergeSortArray[k] = array[j];
                        j++;
                        k++;
                    }
                }
                else{
                    while (j <= mid){
                        mergeSortArray[k] = array[i];
                        i++;
                        k++;    
                    }
                }
                for (k = start; j <= end; k++){
                    array[k] = mergeSortArray[k];
                    i++;
                }
            }
            Display(array);       
        }
    }
}