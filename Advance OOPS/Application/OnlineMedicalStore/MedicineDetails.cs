using System;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineId = 100;
        public string MedicineID { get;}
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public int Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName, int availableCount, int price, DateTime dateOfExpiry){
            s_medicineId++;
            MedicineID = "MD"+ s_medicineId;
            MedicineName = medicineName;
            AvailableCount =availableCount;
            Price =price;
            DateOfExpiry = dateOfExpiry;           
        }
        public MedicineDetails(string data){
            string[] value = data.Split(",");
            s_medicineId =int.Parse(value[0].Remove(0,3));
            MedicineID = value[0];
            MedicineName = value[1];
            AvailableCount =int.Parse(value[2]);
            Price =int.Parse(value[3]);
            DateOfExpiry = DateTime.Parse(value[4]);           
        }
    }
}