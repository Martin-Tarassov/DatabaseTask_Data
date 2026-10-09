using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class VisitExamination
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? PerformedDate { get; set; }
        public string? Result { get; set; }

        public Guid VisitId { get; set; }
        public Visit Visit { get; set; }

        public Guid ExaminationId { get; set; }
        public Examination Examination { get; set; }
    }
}