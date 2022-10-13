using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Animal
    {
        public virtual void MakeSound(){
            Console.WriteLine($"Animal Sound");
        }
    }
}