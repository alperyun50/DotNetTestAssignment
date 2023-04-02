using Microsoft.EntityFrameworkCore;

namespace DotNetTestAssignment.Models
{
    public class DbContexts : DbContext
    {
        public DbContexts(DbContextOptions<DbContexts> opt) : base(opt)
        {
            
        }

        public DbSet<AirportDetail> AirportDetails { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Location>().HasNoKey();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirportDetail>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<AirportDetail>()
                .Ignore(a => a.Location);

            modelBuilder.Entity<AirportDetail>()
                .OwnsOne(a => a.Location);

        }

    }
}
