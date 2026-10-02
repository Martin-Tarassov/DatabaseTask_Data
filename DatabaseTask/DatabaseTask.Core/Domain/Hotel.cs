using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Hotel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RoomAmmount { get; set; }

        public ICollection<Employee> Employees { get; set; } 
            = new List<Employee>();
    }
}
