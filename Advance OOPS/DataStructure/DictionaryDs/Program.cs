using System;

namespace DictionaryDs{
    class Program{
        public static void Main(string[] args)
        {
            KeyValue<int,string> dictionary = new KeyValue<int, string>();
            dictionary.Add(1,"John");
            dictionary.Add(2,"Siva");
            dictionary.Add(3,"Tamil");

            foreach(KeyValue<int,string> i in dictionary){
                Console.WriteLine($"Key : {i.Key}\t Value : {i.Value}");
            }
        }
    }
}