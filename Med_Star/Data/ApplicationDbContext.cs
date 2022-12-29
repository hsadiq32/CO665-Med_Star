using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Med_Star.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Med_Star.Models.Person> Person { get; set; }

        public DbSet<Med_Star.Models.Doctor> Doctor { get; set; }
        public DbSet<Med_Star.Models.Patient> Patient { get; set; }
        public DbSet<Med_Star.Models.Branch> Branch { get; set; }
        public DbSet<Med_Star.Models.Appointment> Appointment { get; set; }
    }
}