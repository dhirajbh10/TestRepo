using System;
namespace HippoAPIAssignment.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Gender { get; set; }      
        public DateTime ModifiedDate { get; set; }
    }
}
