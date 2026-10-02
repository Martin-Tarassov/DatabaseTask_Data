using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class ServiceOrder
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }

        public Guid ServiceId { get; set; }
        public Services Service { get; set; }

        public Guid BookingId { get; set; }
        public Booking Book { get; set; }
    }
}
