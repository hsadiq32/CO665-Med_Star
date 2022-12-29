using Med_Star.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Med_Star.Pages.Patients
{
    public class IndexModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public IndexModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Patient != null)
            {
                Patient = await _context.Patient
                    .Include(d => d.Person)
                    .ToListAsync();
            }
        }
    }
}
