using System;
namespace PartialClass{
    class Program{
        public static void Main(string[] args)
        {
            StudentDetails student = new StudentDetails("John","Rajan", DateTime.Now, Gender.Male, 10,10,100);
            student.ShowDetails();
            student.CheckEligiblity(75.0);
        }
    }
}