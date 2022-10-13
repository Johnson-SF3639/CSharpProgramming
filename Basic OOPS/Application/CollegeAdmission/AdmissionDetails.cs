using System;

namespace CollegeAdmission
{
    public enum Status {Default, Applied, Canceled}
    public class AdmissionDetails
    {
        private static int s_admissionId;
        public string AdminsionId { get; set; }
        public string StudentId { get; set; }
        public string DepartmentId { get; set; }
        public Status Status { get; set; }

        
        public AdmissionDetails(string studentId,string departmentId, Status status){
            s_admissionId++;
            AdminsionId = "AID"+s_admissionId;
            StudentId = studentId;
            DepartmentId = departmentId;
            Status= status;
        }
        
        public AdmissionDetails(string data){
            string[] value = data.Split(',');
            s_admissionId = int.Parse(value[0].Remove(0,3));
            AdminsionId = value[0];
            StudentId = value[1];
            DepartmentId = value[1];
            Status = Enum.Parse<Status>(value[2]);
        }
    }
}