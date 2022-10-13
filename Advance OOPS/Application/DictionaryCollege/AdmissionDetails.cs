using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public enum Status { Default, Admitted, Cancelled, Booked }
    public class AdmissionDetails
    {
        private static int s_admissionId = 1000;
        public string AdmissionId { get; set; }
        public string StudentId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public Status AdmissionStatus { get; set; }

        public AdmissionDetails(string studentId, string departmentId, DateTime admissionDate, Status admissionStatus)
        {
            s_admissionId++;
            AdmissionId = "AID" + s_admissionId;
            StudentId = studentId;
            DepartmentId = departmentId;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }
    }
}