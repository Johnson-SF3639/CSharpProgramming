using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    // public enum Dose {Default, One, Two, Three};
    public class Vaccination
    {
        
        private static int s_vaccinationID =1000;
        
        public string VaccinationID { get; }
        public string RegisterNumber {get; set;}
        public string VaccineID {get; set;}
        public int DoseNumber {get; set;}
        public DateTime VaccinatedDate { get; set; } 
    
        public Vaccination(string registerNumber,  string vaccineID, int doseNumber, DateTime vaccinatedDate){
            s_vaccinationID++;
            VaccinationID ="VID"+s_vaccinationID;
            RegisterNumber = registerNumber;
            VaccineID = vaccineID;
            DoseNumber = doseNumber;
            VaccinatedDate = vaccinatedDate;
        }
        public Vaccination(string data){
            string[] value = data.Split(',');
            // s_vaccinationID = int.Parse(value[0].Remove(0,3));
            VaccinationID =value[0];
            RegisterNumber = value[1];
            VaccineID = value[2];
            DoseNumber =int.Parse(value[3]);
            VaccinatedDate = DateTime.Parse(value[4]);
        }
    }
}