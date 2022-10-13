using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw : IRectangle
    {
        public double Area { get; set; }
        public double Length { get; set; }
        public double Breath {get; set;}

        public void GetData(double length, double breath){
            Length = length;
            Breath = breath;
        }

        public void CalculateArea(){
            Area = Length * Breath;
            Console.WriteLine($"Area : {Area}");            
        }
    }
}