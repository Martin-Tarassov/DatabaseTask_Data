using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Payroll
    {
        [Key]
        public Guid Id { get; set; }
        public float Sum { get; set; }
        public DateTime Date { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
