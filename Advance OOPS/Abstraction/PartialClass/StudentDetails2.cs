using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, int physics, int chemistry, int maths){
            s_studentId++;
            StudentId = "SF"+ s_studentId;
            StudentName = name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        
    }
}