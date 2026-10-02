using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public float PaymentAmmount { get; set; }
        public string PaymentMethod { get; set; }

        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid GuestId { get; set; }   
        public Guests Guest { get; set; }
    }
}
