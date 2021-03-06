using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class HrmsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Hrms;Trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>().ToTable("Applicants");
            modelBuilder.Entity<Employer>().ToTable("Employers");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<JobAdvert> JobAdverts { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }

    }
}
