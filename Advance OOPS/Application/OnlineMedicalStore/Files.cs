using System;
using System.IO;

namespace OnlineMedicalStore
{
    public class Files
    {
        public static void Create(){
            if(!Directory.Exists("Details")){
                Console.WriteLine($"Folder Create Successfully");
                Directory.CreateDirectory("Details");                
            }
            if(!File.Exists("Details/Register.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/Register.csv");
            }
            if(!File.Exists("Details/Medicine.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/Medicine.csv");
            }
            if(!File.Exists("Details/Order.csv")){
                Console.WriteLine($"File Create Successfully");
                File.Create("Details/Order.csv");
            }
        }

        public static void ReadFile(){
            string[] register = File.ReadAllLines("Details/Register.csv");
            foreach(string data in register){
                RegisterationDetails registerData = new RegisterationDetails(data);
                Operations.userList.Add(registerData);
            }
            string[] order = File.ReadAllLines("Details/Order.csv");
            foreach(string data in order){
                OrderDetails orderData = new OrderDetails(data);
                Operations.orderList.Add(orderData);
            }
            string[] medicine = File.ReadAllLines("Details/Medicine.csv");
            foreach(string data in medicine){
                MedicineDetails medicineData = new MedicineDetails(data);
                Operations.medicineList.Add(medicineData);
            }
        }

        public static void WriteToFile(){
            string[] user = new string[Operations.userList.Count];
            for(int i=0; i<Operations.userList.Count; i++){
                user[i] = Operations.userList[i].UserId +','+ Operations.userList[i].UserName +','+ Operations.userList[i].Age +','+ Operations.userList[i].City +','+ Operations.userList[i].PhoneNumber +','+ Operations.userList[i].Balance;
            }
            File.WriteAllLines("Details/Register.csv",user);

            string[] medicine = new string[Operations.medicineList.Count];
            for(int i=0; i<Operations.medicineList.Count; i++){
                medicine[i] = Operations.medicineList[i].MedicineID +','+ Operations.medicineList[i].MedicineName +','+ Operations.medicineList[i].AvailableCount +','+ Operations.medicineList[i].Price +','+ Operations.medicineList[i].DateOfExpiry;
            }
            File.WriteAllLines("Details/Medicine.csv",medicine);

            string[] order = new string[Operations.orderList.Count];
            for(int i=0; i<Operations.orderList.Count; i++){
                order[i] = Operations.orderList[i].OrderID +','+ Operations.orderList[i].UserID +','+ Operations.orderList[i].MedicineID +','+ Operations.orderList[i].MedicineCount +','+ Operations.orderList[i].TotalPrice +','+ Operations.orderList[i].OrderDate +','+ Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("Details/Order.csv",order);
        }
    }
}