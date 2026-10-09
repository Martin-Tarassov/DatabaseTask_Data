using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Medication
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ActiveSubstance { get; set; }
        public string Manufacturer { get; set; }
        public string? Description { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }
            = new List<Prescription>();
    }
}