using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Bookable> Bookables { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guests> Guests { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var fk in modelBuilder.Model.GetEntityTypes()
                         .SelectMany(e => e.GetForeignKeys()))
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}