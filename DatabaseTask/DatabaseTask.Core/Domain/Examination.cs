using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Examination
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }

        public ICollection<VisitExamination> VisitExaminations { get; set; }
            = new List<VisitExamination>();
    }
}