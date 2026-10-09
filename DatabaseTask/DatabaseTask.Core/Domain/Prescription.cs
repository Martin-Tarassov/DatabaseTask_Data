using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Prescription
    {
        [Key]
        public Guid Id { get; set; }
        public string Dosage { get; set; }
        public int TimesPerDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Guid VisitId { get; set; }
        public Visit Visit { get; set; }

        public Guid MedicationId { get; set; }
        public Medication Medication { get; set; }
    }
}