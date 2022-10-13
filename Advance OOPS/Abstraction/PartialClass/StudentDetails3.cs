using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
        public void ShowDetails(){
            Console.WriteLine($"\nStudent Id : {StudentId}");
            Console.WriteLine($"Student Name : {StudentName}");
            Console.WriteLine($"Father Name : {FatherName}");
            Console.WriteLine($"Student Date of Birth : {DOB.ToShortDateString()}");
            Console.WriteLine($"Student Gender : {Gender}");
            Console.WriteLine($"Physics Mark : {Physics}");
            Console.WriteLine($"Chemistry Mark : {Chemistry}");
            Console.WriteLine($"Maths Mark : {Maths}");
        }
        public void CheckEligiblity(double cutOff){
            double average = (double)(Physics+Chemistry+Maths)/3.0;
            if(average >= cutOff){
                Console.WriteLine($"\nMost Welcome");
                
            }
            else{                
                Console.WriteLine($"\nKatham , Tata, Bye.... Bye....\n");
            }        
        }
        
    }
}