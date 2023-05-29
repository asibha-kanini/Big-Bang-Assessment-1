using System.ComponentModel.DataAnnotations;

namespace Big_Bang_Assessment_1.Model
{
    public class Employee
    {
        [Key]
        public int? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
