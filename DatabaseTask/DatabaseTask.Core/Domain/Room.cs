using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Room
    {
        [Key]
        public Guid Id { get; set; }
        public string RoomType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int RoomNr { get; set; }
        public int Floor { get; set; }
        public bool AirCon { get; set; }

        public ICollection<Bookable> Bookables { get; set; } 
            = new List<Bookable>();
    }
}
