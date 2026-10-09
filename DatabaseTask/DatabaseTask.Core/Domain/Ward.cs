using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        [Key]
        public Guid Id { get; set; }
        public string Number { get; set; }
        public int Floor { get; set; }
        public int BedCount { get; set; }

        public ICollection<Hospitalization> Hospitalizations { get; set; }
            = new List<Hospitalization>();
    }
}