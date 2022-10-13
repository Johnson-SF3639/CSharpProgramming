using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class Operation
    {
        public static void MainMenu(){
            
        PersonalDetails person = new PersonalDetails("John","Rajan",Gender.Male,9443234567);

        person.ShowDetails();

        StudentDetails student = new StudentDetails("EID1001","John","Rajan", Gender.Male,923456,Department.CSE,"Final");

        student.ShowStudent();

        CustomerDetails customer = new CustomerDetails("John","Rajan",Gender.Male,9443234567);

        customer.Recharge();
        customer.ShowCustomer();
        
        }
        
    }
}