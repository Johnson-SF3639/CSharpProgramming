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
                            MergeSort(intArray, 0, intArray.Length-1);
                            Display(intArray);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"\nQuick Sort");
                            int[] sortArray = QuickSort(intArray,0,intArray.Length-1);
                            Console.WriteLine($"Sorted Array with Quick Sort");
                            Display(sortArray);
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


        static public void MainMerge(int[] numbers, int left, int mid, int right)    
        {    
            int[] temp = new int[25];    
            int i, eol, num, pos;    
            eol = (mid - 1);    
            pos = left;   
            num = (right - left + 1);     
  
            while ((left <= eol) && (mid <= right))    
            {    
                if (numbers[left] <= numbers[mid])    
                    temp[pos++] = numbers[left++];    
                else    
                    temp[pos++] = numbers[mid++];    
            }    
            while (left <= eol)    
                temp[pos++] = numbers[left++];    
            while (mid <= right)    
                temp[pos++] = numbers[mid++];   
            for (i = 0; i < num; i++)    
            {    
                numbers[right] = temp[right];    
                right--;    
            }    
        }   
        public static void MergeSort(int[] array, int left, int right)
        { 
            int mid;    
            if (right > left)    
            {    
                mid = (right + left) / 2;    
                MergeSort(array, left, mid);    
                MergeSort(array, (mid + 1), right);    
                MainMerge(array, left, (mid + 1), right);    
            } 

        }

        static void Swap(int[] numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
        static int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (numbers[j] < pivot)
                {
                    i++;
                    Swap(numbers, i, j);
                }
            }
            Swap(numbers, i + 1, high);
            return (i + 1);
        }
        static int[] QuickSort(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(numbers, low, high);
                QuickSort(numbers, low, pi - 1);
                QuickSort(numbers, pi + 1, high);
            }
            return numbers;
        }

    }
}