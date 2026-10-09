using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }

        public ICollection<Visit> Visits { get; set; }
            = new List<Visit>();
        public ICollection<Hospitalization> Hospitalizations { get; set; }
            = new List<Hospitalization>();
    }
}