using System;
using System.Collections.Generic;
namespace EBBill
{
    public enum WorkLocation { Default, Madura, Eymard };
    public enum Gender { Default, Male, Female };
    class Program
    {
        public static void Main(string[] args)
        {
            Operations.MainMenu();
        }
    }
}