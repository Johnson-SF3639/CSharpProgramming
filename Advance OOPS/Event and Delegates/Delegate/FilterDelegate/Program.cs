using System;
using System.Collections.Generic;

namespace FilterDelegates{
    class Program{
        static void DisplayPeople(string title, List<Person> people, FilterDelegates filter){
            Console.WriteLine($"\nPeople in  {title} list are :");
            foreach(Person i in people){
                if(filter(i)){
                    Console.WriteLine($"{i.Name} is {i.Age} year Old");
                }
            }
            
        }
        public static void Main(string[] args)
        {
            Person person1 = new Person(){Name = "John", Age =41};
            Person person2 = new Person(){Name = "Siva", Age =69};
            Person person3 = new Person(){Name = "Tamil", Age =12};
            Person person4 = new Person(){Name = "Ram", Age =10};
            Person person5 = new Person(){Name = "Kemil", Age =30};
            Person person6 = new Person(){Name = "Sethu", Age =50};

            List<Person> person = new List<Person>(){person1,person2,person3,person4,person5,person6};

            DisplayPeople("Children :", person,IsChild);
            DisplayPeople("Adults :", person,IsAdult);
            DisplayPeople("Seniors :", person,IsSenior);
            DisplayPeople("Voters :", person,IsVoter);
        }
        static bool IsChild(Person p){ return p.Age < 15;}
        static bool IsVoter(Person p){ return p.Age >= 18;}
        static bool IsAdult(Person p){ if(p.Age >= 18 && p.Age < 50){ return true; } else{ return false;} }
        static bool IsSenior(Person p){ return p.Age >= 50;}


    }
}