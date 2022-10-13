using System;
/// <summary>
/// Used to process the college admission using this application
/// </summary>
namespace CollegeAdmission
{
    /// <summary>
    /// Used to select a student's gender information
    /// </summary>
    public enum Gender {Default, Male, Female, Transgender}

    /// <summary>
    /// Class <see cref="StudentDetails"/> used to collect student's details for the admission.
    /// </summary>
    public class StudentDetails
    {
         //Fields
        // private string _name="John";
       
        /// <summary>
        /// Private Static RegisterNumber used to provide name for a studet in object of <see cref="StudentDetials"> class Object's
        /// </summary>
        private static int s_registerNumber=3000;

        //Property
        // public string Name { get{return _name;} set{_name = value;} }

        //Auto Property
        
        /// <summary>
        /// Property Name is RegisterNumber
        /// </summary>
        /// <value></value>
        public string RegisterNumber {get;}
        
        /// <summary>
        /// Property Name is Name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        /// <summary>
        /// Property Name is Father Name
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }

        /// <summary>
        /// DateTime DOB Property
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }

        /// <summary>
        /// Gender is Enum type Property
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }

        /// <summary>
        /// Phone Property
        /// </summary>
        /// <value></value>
        public long Phone { get; set; }

        /// <summary>
        /// Mail Property
        /// </summary>
        /// <value></value>
        public string Mail { get; set; }

        /// <summary>
        /// Physics Property
        /// </summary>
        /// <value></value>
        public int Physics{ get; set; }

        /// <summary>
        /// Chemistry Property
        /// </summary>
        /// <value></value>
        public int Chemistry{ get; set; }

        /// <summary>
        /// Property Maths used to provide maths for a studet in object of <see cref="StudentDetials"> class Object's
        /// </summary>
        /// <value></value>
        public int Maths{ get; set; }

        // Parameter Constructor
        /// <summary>
        /// Constructor of 
        /// </summary>
        /// <param name="name">Used to assign the value  to property</param>
        /// <param name="fatherName">Used to assign the value  to property</param>
        /// <param name="dob">Used to assign the value  to property</param>
        /// <param name="gender">Used to assign the value  to property</param>
        /// <param name="phone">Used to assign the value  to property</param>
        /// <param name="mail">Used to assign the value  to property</param>
        /// <param name="physics">Used to assign the value  to property</param>
        /// <param name="chemistry">Used to assign the value  to property</param>
        /// <param name="maths">Used to assign the value  to property</param>
        public StudentDetails(string name, string fatherName, DateTime dob, Gender gender, long phone,string mail, int physics, int chemistry, int maths){
            s_registerNumber++;
            RegisterNumber="SF"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Phone=phone;
            Mail=mail;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public StudentDetails(string data){
            string[] value = data.Split(',');
            s_registerNumber = int.Parse(value[0].Remove(0,2));
            RegisterNumber = value[0];
            Name = value[1];
            FatherName = value[2];
            DOB = DateTime.Parse(value[3]);
            Gender = Enum.Parse<Gender>(value[4]);
            Phone = int.Parse(value[5]);
            Mail = value[6];
            Physics = int.Parse(value[7]);
            Chemistry = int.Parse(value[8]);
            Maths = int.Parse(value[9]);


        }

        //method
        /// <summary>
        /// Method of <see cref="CheckEligiblity"/> is used for check the the student are eligible are not.
        /// </summary>
        /// <param name="cutOff">Free defined value 75.0</param>
        /// <returns></returns>
        public bool CheckEligiblity(double cutOff){
            double average = (double) (Physics+Chemistry+Maths)/3.0;
            if(average >= cutOff){
                return true;
            }else{
                return false;
            }
        }

        /// <summary>
        /// Method of <see cref="ShowDetails"/> is Used for Show the details about Student
        /// </summary>
        public void ShowDetails(){
            Console.WriteLine($"\nPreson Details : ");
            Console.WriteLine($"Your Register Number : {RegisterNumber}");
            Console.WriteLine($"Your Name : {Name}");
            Console.WriteLine($"Your Father Name : {FatherName}");
            Console.WriteLine($"Your Date of Birth : {DOB.ToShortDateString()}");
            Console.WriteLine($"Your Gender : {Gender}");
            Console.WriteLine($"Your Phone No :  {Phone}");
            Console.WriteLine($"Your Email : {Mail}");
            Console.WriteLine($"Your Physics Mark : {Physics}");
            Console.WriteLine($"Your Chemistry Mark : {Chemistry}");
            Console.WriteLine($"Your Maths Mark : {Maths}");
        }
        
    }
}