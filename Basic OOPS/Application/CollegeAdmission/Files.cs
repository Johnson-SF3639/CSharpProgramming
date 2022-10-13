using System;
using System.IO;

namespace CollegeAdmission
{
    public static class Files
    {
        public static void Create(){
            if(!Directory.Exists("College")){
                Console.WriteLine($"Creating Folder");
                Directory.CreateDirectory("College");                
            }
            if(!File.Exists("College/StudentDetails.csv")){
                Console.WriteLine($"Creating College File");
                File.Create("College/StudentDetails.csv");                
            }
            if(!File.Exists("College/DepartmentDetails.csv")){ 
                Console.WriteLine($"Creating Department File");
                File.Create("College/DepartmentDetails.csv");                
            }
            if(!File.Exists("College/AdmissionDetails.csv")){
                Console.WriteLine($"Creating Admission File");
                File.Create("College/AdmissionDetails.csv");                
            }
        }   

        public static void ReadFile(){
            string[] studentsDetails = File.ReadAllLines("College/StudentDetails.csv");
            foreach(string data in studentsDetails){
                StudentDetails student = new StudentDetails(data);
                Operation.studentList.Add(student);
            }

            string[] departmentDetails = File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(string data in departmentDetails){
                DepartmentDetails department = new DepartmentDetails(data);
                Operation.departmentList.Add(department);
            }

            string[] admissionDetails = File.ReadAllLines("College/AdmissionDetails.csv");
            foreach(string data in admissionDetails){
                AdmissionDetails admission = new AdmissionDetails(data);
                Operation.admissionList.Add(admission);
            }

        }     

        public static void WriteToFile(){
            string[] studentDetails = new string[Operation.studentList.Count];
            for(int i =0; i<Operation.studentList.Count; i++){
                studentDetails[i] = Operation.studentList[i].RegisterNumber +","+Operation.studentList[i].Name +","+Operation.studentList[i].FatherName +","+Operation.studentList[i].DOB +","+Operation.studentList[i].Gender +","+Operation.studentList[i].Phone +","+Operation.studentList[i].Mail +","+Operation.studentList[i].Physics +","+Operation.studentList[i].Chemistry+","+ Operation.studentList[i].Maths;
            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);
            
            string[] departmentDetails = new string[Operation.departmentList.Count];
            for(int i =0; i<Operation.departmentList.Count; i++){
                departmentDetails[i] = Operation.departmentList[i].DepartmentId +","+Operation.departmentList[i].DepartmentName +","+Operation.departmentList[i].NoOfSeat;
            }
            File.WriteAllLines("College/departmentDetails.csv",departmentDetails);
            
            string[] admissionDetails = new string[Operation.admissionList.Count];
            for(int i =0; i<Operation.admissionList.Count; i++){
                admissionDetails[i] = Operation.admissionList[i].AdminsionId +","+Operation.admissionList[i].StudentId +","+Operation.admissionList[i].DepartmentId +","+Operation.admissionList[i].Status;
            }
            File.WriteAllLines("College/admissionDetails.csv",admissionDetails);
        }
    }
}