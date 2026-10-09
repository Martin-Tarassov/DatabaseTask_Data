using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Hospitalization
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string Reason { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public Guid WardId { get; set; }
        public Ward Ward { get; set; }

        public Guid? VisitId { get; set; }
        public Visit? Visit { get; set; }
    }
}