using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstraAbstractBase
    {
        protected string name;
        public abstract string Name { get; set; }
        public double  Amount { get; set; }
        

        public void Display(){
            Console.WriteLine($"\nName : {name}");
        }

        public abstract void Salary(int dates);
    }
}