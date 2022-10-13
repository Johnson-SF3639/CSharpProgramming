using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public enum Gender {Default,Male,Female,Transgender}
    public partial class StudentDetails
    {
        private static int s_studentId = 3000;
        public string StudentId { get; }
        public string StudentName {get; set;}
        public string FatherName {get; set;}
        public DateTime DOB {get; set;}
        public Gender Gender {get; set;}
        public int Physics {get; set;}
        public int Chemistry {get; set;}
        public int Maths {get; set;}


    }
}