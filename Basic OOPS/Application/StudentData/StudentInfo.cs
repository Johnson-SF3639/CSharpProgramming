using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData
{
    public static class StudentInfo
    {
        public static int RegisterNumber=0;
        public static string Name { get; set; }

        static StudentInfo(){
            Name = "John";
            RegisterNumber = 3936;
        }

        public static void Display(){
            Console.WriteLine($"Your Name is {Name} and ID {RegisterNumber}");
        }
    }
}