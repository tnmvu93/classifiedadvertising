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

    public class ClassifiedAdvertisingDbContextFactory : IDesignTimeDbContextFactory<ClassifiedAdvertisingDbContext>
    {
        public ClassifiedAdvertisingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ClassifiedAdvertisingDbContext>();
            builder.UseSqlServer("Server=HSSSC1PCL02096\\SQL2014;Database=ClassifiedAdvertising;Trusted_Connection=True;");

            return new ClassifiedAdvertisingDbContext(builder.Options);
        }
    }
}
