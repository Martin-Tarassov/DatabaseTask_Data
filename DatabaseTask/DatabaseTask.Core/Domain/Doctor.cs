using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeNumber { get; set; }
        public string Phone { get; set; }
        public string Specialty { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Visit> Visits { get; set; }
            = new List<Visit>();
    }
}