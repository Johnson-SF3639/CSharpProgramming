using System;
namespace EnumeratedApplication{
    public enum Gender {Default, Male, Female, TransGender}
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine($"Select Gender Options Male, Female, Transgender");
            Gender gender1 = Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.WriteLine(gender1);
            
            Console.WriteLine($"Select Gender Options Male, Female, Transgender");
            Gender gender2 = Gender.Default;
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true, out gender2);

            while(!temp || !((int)gender2<4) && (int)gender2>0){
                Console.WriteLine("Invalid Gender\n Enter again");
                temp = Enum.TryParse<Gender>(Console.ReadLine(), out gender2);
            }
            Console.WriteLine(gender2);
            
                        
            
        }
    }
}