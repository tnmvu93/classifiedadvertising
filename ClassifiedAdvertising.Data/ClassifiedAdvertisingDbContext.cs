using ClassifiedAdvertising.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ClassifiedAdvertising.Data
{
    public class ClassifiedAdvertisingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ClassifiedAdvertisingDbContext(DbContextOptions<ClassifiedAdvertisingDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
