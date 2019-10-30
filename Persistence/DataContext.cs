using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<User> users { get; set; }

        public DataContext(DbContextOptions options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(
                new User { username = "Name -1", userId = -1 },
                new User { username = "Name -2", userId = -2 },
                new User { username = "Name -3", userId = -3 }

            );

        }

    }

}