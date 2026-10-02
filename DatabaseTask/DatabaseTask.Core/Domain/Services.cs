using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Services
    {
        [Key]
        public Guid Id { get; set; }
        public string ServiceType { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }


        //nav property
        public ICollection<ServiceOrder> ServiceOrders { get; set; }
                = new List<ServiceOrder>();

    }
}
