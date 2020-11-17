using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public DbSet<AnimalType> Types { get; set; }

        public AnimalShelterContext(DbContextOptions options) : base(options) { }
    }
}