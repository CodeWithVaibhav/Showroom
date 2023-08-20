using Microsoft.EntityFrameworkCore;
using Showroom.Data.Configurations;
using Showroom.Data.Entities;

namespace Showroom.Data
{
    public class ShowroomDbContext: DbContext
    {
        public DbSet<User> User { get; set; }

        public ShowroomDbContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
