using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public DbSet<AnimalType> AnimalTypes { get; set; }

        public AnimalShelterContext(DbContextOptions options) : base(options) { }
    }
}