using System;
namespace StringAssignment{
    class Program{
        public static void Main(string[] args)
        {
            int count=0;
            string sentance, search;
            Console.WriteLine("Enter the Sentence :");
            sentance = Console.ReadLine();
            Console.WriteLine("Enter the Search Word :");
            search =Console.ReadLine();

            string[] spliter = sentance.Split(new string[] {search},StringSplitOptions.None);             
            foreach(string i in spliter){
            Console.WriteLine(i);
                count+=1;                
            }
            Console.WriteLine(count-1);
        }
    }
}