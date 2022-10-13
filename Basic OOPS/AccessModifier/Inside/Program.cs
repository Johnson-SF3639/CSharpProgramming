using System;
namespace Inside{
    class Inside{
        public static void Main(string[] args)
        {
            First one = new First();
            Second two = new Second();
            Console.WriteLine($"{one.PublicNumber}");

            Console.WriteLine($"{one.PrivateNumber}");

            Console.WriteLine($"{one.InternalNumber}");

            Console.WriteLine($"{two.ProtectedNumber}");

            Console.WriteLine($"{two.ProtectedInternalNumber}");
            
            
        }
    }
}