using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class TCS : AbstraAbstractBase
    {
        //Abstruct Property
        public override string Name{ get{return name;} set{ name = value;}}

        public override void Salary(int dates){
            Display();
            Amount = (double) dates * 300;
            Console.WriteLine($"Your Salary is : {Amount}");
        }
        
    }
}