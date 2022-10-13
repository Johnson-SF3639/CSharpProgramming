using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission1
{
    public class StudentDetail
    {
        public string RegisterNumber { get;}        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Physics{ get; set; }
        public int Chemistry{ get; set; }
        public int Maths{ get; set; }
        
        public StudentDetail(){
            Name="John";
            FatherName="Rajan";
            DOB =DateTime.Parse("12/12/2012");
            Gender="Male";
            Phone=0000000000;
            Mail="exampli@gmail.com";
            Physics=100;
            Chemistry=100;
            Maths=100;
        }

        ~StudentDetail(){

        }
    }
}
