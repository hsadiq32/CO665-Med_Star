using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Med_Star.Models;

namespace Med_Star.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Med_Star.Models.Doctor> Doctor { get; set; }
        public DbSet<Med_Star.Models.Patient> Patient { get; set; }
        public DbSet<Med_Star.Models.MedStarBranch> MedStarBranch { get; set; }
        public DbSet<Med_Star.Models.Appointment> Appointment { get; set; }
    }
}