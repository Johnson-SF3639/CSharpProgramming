using System;
using System.Collections.Generic;
using System.IO;
namespace ListFile{
    class Program{
        public static List<StudentDetails> vlist = new List<StudentDetails>();
        public static void Main(string[] args)
        {
            vlist.Add(new StudentDetails(){Name="John",FatherName="Rajan",Gender= Gender.Male, DOB=new DateTime(2020,12,12)});
            vlist.Add(new StudentDetails(){Name="Siva",FatherName="Balan",Gender= Gender.Male, DOB=new DateTime(2020,11,12)});
            vlist.Add(new StudentDetails(){Name="Tamil",FatherName="Selven",Gender= Gender.Male, DOB=new DateTime(2020,10,12)});
            vlist.Add(new StudentDetails(){Name="Sehu",FatherName="Pathi",Gender= Gender.Male, DOB=new DateTime(2020,12,11)});

            Insert(vlist);
            Display();
            // Update();
        }

        static void Insert(List<StudentDetails> vlist){
            StreamWriter write = null;
            if(!File.Exists("Data.csv")){
                Console.WriteLine($"File doesn't Exist. Creating a new CSV file");
                File.Create("Data.csv");                
            }else{
                Console.WriteLine($"File Found");
            }
            write = new StreamWriter(File.OpenWrite("Data.csv"));
            foreach(var v in vlist){
                write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.DOB.ToString("dd/MM/yyyy"));
            }
            write.Close();
        }

        static void Display(){
            StreamReader reader = null;
            List<StudentDetails> listA = new List<StudentDetails>();
            if(File.Exists("Data.csv")){
                reader = new StreamReader(File.OpenRead("Data.csv"));
                while(!reader.EndOfStream){
                    var line = reader.ReadLine();
                    var values = line.Split(",");
                    if(values[0]!=""){
                        listA.Add(new StudentDetails(){Name= values[0], FatherName = values[1], Gender = Enum.Parse<Gender>(values[2]),DOB = DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                    }
                }
            }else{
                Console.WriteLine($"File doen't Exist");
            }
            reader.Close();
            foreach(var show in listA){
                Console.WriteLine($"\nYour Name : {show.Name}\nFather Name : {show.FatherName}\nGender : {show.Gender}\nDate of Birth : {show.DOB.ToShortDateString()}");
                
            }
        }

        // static void Update(){
        //     Console.WriteLine($"To Update your Info\n Select your Options");
        //     int choice = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Enter the Name to be Updated");
        // }


    }
}