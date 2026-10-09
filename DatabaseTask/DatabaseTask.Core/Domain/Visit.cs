using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Reason { get; set; }
        public string? Summary { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<VisitExamination> VisitExaminations { get; set; }
            = new List<VisitExamination>();
        public ICollection<Prescription> Prescriptions { get; set; }
            = new List<Prescription>();
        public ICollection<Hospitalization> Hospitalizations { get; set; }
            = new List<Hospitalization>();
    }
}