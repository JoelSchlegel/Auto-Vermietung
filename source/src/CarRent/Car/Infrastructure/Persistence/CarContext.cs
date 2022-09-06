namespace CarRent.Car.Infrastructure.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using CarRent.Car.Domain;

    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
