using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IMarkDetails
    {
        //No field

        //Property declaration
        int Maths { get; set; }
        int Physics { get; set; }
        int Chemistry { get; set; }
         int Total { get; set;}
         double Average { get; set;}

        //Method Declaration Only
         void GetMark(int maths, int physics, int chemistry);
         void Calculate();
         void ShowMark();

    }
}