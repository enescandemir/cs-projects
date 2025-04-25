using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using Core.Entities.Concrete;

namespace DataAccess.Concrete
{
    public class LicenseTrackContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LicenseTrack;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<License> License { get; set; }
        public DbSet<Program> Program { get; set; }
        public DbSet<ProgramLicense> ProgramLicense { get; set; }
        public DbSet<Entities.Concrete.Version> Version { get; set; }
        public DbSet<UpdateTable> UpdateTable { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaims> UserOperationClaims { get; set; }
    }
}
