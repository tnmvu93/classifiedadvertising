using ClassifiedAdvertising.Data.Entities;
using ClassifiedAdvertising.Data.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClassifiedAdvertising.Data
{
    public class ClassifiedAdvertisingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<TypeAdvertising> TypeAdvertisings { get; set; }
        public DbSet<Advertising> Advertisings { get; set; }

        public ClassifiedAdvertisingDbContext(DbContextOptions<ClassifiedAdvertisingDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UserConfiguration(modelBuilder.Entity<User>());
        }
    }

    public class ClassifiedAdvertisingDbContextFactory : IDesignTimeDbContextFactory<ClassifiedAdvertisingDbContext>
    {
        public ClassifiedAdvertisingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ClassifiedAdvertisingDbContext>();
            //builder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ClassifiedAdvertising;Trusted_Connection=True;");
            builder.UseSqlServer("Server=HSSSC1PCL02096\\SQL2014;Database=ClassifiedAdvertising;Trusted_Connection=True;");

            return new ClassifiedAdvertisingDbContext(builder.Options);
        }
    }
}
