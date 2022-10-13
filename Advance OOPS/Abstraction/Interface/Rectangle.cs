using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IRectangle
    {
        double Length { get; set; }
        double Breath {get; set;}

        void CalculateArea();

    }
}