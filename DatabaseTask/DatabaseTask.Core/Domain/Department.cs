using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public string Phone { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
            = new List<Doctor>();
    }
}