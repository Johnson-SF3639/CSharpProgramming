using System;
namespace ArrayListDS
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList<dynamic> arrayList = new ArrayList<dynamic>();
            Console.WriteLine($"HI");
            arrayList.Add(1);
            arrayList.Add("Bill");
            arrayList.Add(2);
            arrayList.Add(true);
            arrayList.Add(4);
            Console.WriteLine($"Diesplay");
            foreach (dynamic array in arrayList)
            {
                Console.WriteLine($"{array}");
            }

            arrayList.Remove(1);
            Console.WriteLine($"\nremove");
            foreach (dynamic array in arrayList)
            {
                Console.WriteLine($"{array}");
            }


            arrayList.RemoveAt(0);
            Console.WriteLine($"\nremove At");
            foreach (dynamic array in arrayList)
            {
                Console.WriteLine($"{array}");
            }
            // bool value = arrayList.Contains("Bill");
            // Console.WriteLine($"{}");

        }
    }
}