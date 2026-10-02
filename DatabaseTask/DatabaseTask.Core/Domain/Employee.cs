using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PersonalId { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public ICollection<Booking> Bookings { get; set; } 
            = new List<Booking>();
        public ICollection<Payment> Payments { get; set; } 
            = new List<Payment>();
        public ICollection<Payroll> Payrolls { get; set; }
            = new List<Payroll>();
    }
}
