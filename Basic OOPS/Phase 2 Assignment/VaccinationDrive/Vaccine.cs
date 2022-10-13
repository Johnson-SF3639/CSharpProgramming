using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationDrive
{
    public enum VaccineName {Default, Covishield, Covaccine};
    public class Vaccine
    {
        private static int s_vaccine =1000;
        
        public string VaccineID { get; }
        public VaccineName VaccineName {get; set;}
        public int NoOfDoseAvailable {get; set;}

        public Vaccine(VaccineName name, int age){
            s_vaccine++;
            VaccineID ="CID"+ s_vaccine;
            VaccineName = name;
            NoOfDoseAvailable = age;
        }
        public Vaccine(string data){
            string[] value = data.Split(',');
            s_vaccine = int.Parse(value[0].Remove(0,4));
            VaccineID = value[0];
            VaccineName =Enum.Parse<VaccineName>(value[1]);
            NoOfDoseAvailable =int.Parse(value[2]);
        }
    }
}
