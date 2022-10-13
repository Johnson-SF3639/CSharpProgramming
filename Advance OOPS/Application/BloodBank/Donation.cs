using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank
{
    public class Donation
    {
        private static int s_donationId = 2000;
        public string DonationId { get; set; }
        public DateTime DonationDate { get; set; }
        public double Weight { get; set; }
        public double BloodPressure { get; set; }
        public double HemoglobinCount  { get; set; }
    
        public Donation(DateTime donationDate, double weight, double bloodPressure, double hemoglobinCount){
            s_donationId++;
            DonationId = "DOID"+ s_donationId;
            DonationDate = donationDate;
            Weight = weight;
            BloodPressure = bloodPressure;
            HemoglobinCount = hemoglobinCount;
        }
        
        public Donation(string data){
            string[] value = data.Split(',');
            s_donationId = int.Parse(value[0].Remove(0,4));
            DonationId = value[0];
            DonationDate = DateTime.Parse(value[1]);
            Weight = int.Parse(value[2]);
            BloodPressure = int.Parse(value[3]);
            HemoglobinCount = int.Parse(value[4]);
        }

    }

}