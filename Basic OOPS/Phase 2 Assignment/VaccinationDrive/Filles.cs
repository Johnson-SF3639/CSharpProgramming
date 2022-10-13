using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public class Files
    {
        public static void Create(){
            //Create File
            if(!Directory.Exists("Details")){
                Console.WriteLine($"Folder Create Successfuly");
                Directory.CreateDirectory("Details");                
            }
            if(!File.Exists("Details/Benficiary.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/Benficiary.csv");
            }
            if(!File.Exists("Details/Vaccination.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/Vaccination.csv");
            }
            if(!File.Exists("Details/Vaccine.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/Vaccine.csv");
            }
        }

        public static void ReadFile(){
            string[] beneficiary = File.ReadAllLines("Details/Benficiary.csv");
            foreach(string data in beneficiary){
                Beneficiary user = new Beneficiary(data);
                Operation.beneficiaryList.Add(user);
            }

            string[] vaccination = File.ReadAllLines("Details/Vaccination.csv");
            foreach(string data in vaccination){
                Vaccination vaccination1 = new Vaccination(data);
                Operation.vaccinationList.Add(vaccination1);
            }

            string[] vaccine = File.ReadAllLines("Details/Vaccine.csv");
            foreach(string data in vaccine){
                Vaccine vaccination1 = new Vaccine(data);
                Operation.vaccineList.Add(vaccination1);
            }
        }

        public static void WriteFile(){
            string[] beneficiary = new string[Operation.beneficiaryList.Count];
            for(int i=0; i<Operation.beneficiaryList.Count; i++){
                beneficiary[i] = Operation.beneficiaryList[i].BeneficiaryID + ',' + Operation.beneficiaryList[i].BeneficiaryName  + ',' + Operation.beneficiaryList[i].Age  + ',' + Operation.beneficiaryList[i].Gender  + ',' + Operation.beneficiaryList[i].MobileNumber  + ',' + Operation.beneficiaryList[i].City; 
            }
            File.WriteAllLines("Details/Benficiary.csv",beneficiary);

            string[] vaccination = new string[Operation.vaccinationList.Count];
            for(int i = 0; i<Operation.vaccinationList.Count; i++){
                vaccination[i]= Operation.vaccinationList[i].VaccinationID + ',' + Operation.vaccinationList[i].RegisterNumber + ',' + Operation.vaccinationList[i].VaccineID + ',' + Operation.vaccinationList[i].DoseNumber + ',' + Operation.vaccinationList[i].VaccinatedDate; 
            }
            File.WriteAllLines("Details/Vaccination.csv",vaccination);

            string[] vaccine = new string[Operation.vaccineList.Count];
            for(int i = 0; i<Operation.vaccineList.Count; i++){
                vaccine[i]= Operation.vaccineList[i].VaccineID + ',' + Operation.vaccineList[i].VaccineName + ',' + Operation.vaccineList[i].NoOfDoseAvailable; 
            }
            File.WriteAllLines("Details/Vaccine.csv",vaccine);
        }


    }
}