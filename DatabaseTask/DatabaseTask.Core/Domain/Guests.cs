using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Guests
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string PersonalId { get; set; }
        public string Citizenship { get; set; }

        public ICollection<Booking> Bookings { get; set; } 
            = new List<Booking>();
        public ICollection<Payment> Payments { get; set; } 
            = new List<Payment>();
    }
}
