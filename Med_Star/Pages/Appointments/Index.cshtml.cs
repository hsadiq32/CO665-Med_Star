using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Med_Star.Data;
using Med_Star.Models;

namespace Med_Star.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public IndexModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Appointment != null)
            {
                Appointment = await _context.Appointment
                    .Include(b => b.Doctor)
                        .ThenInclude(d => d.Person)
                    .Include(c => c.Patient)
                        .ThenInclude(e => e.Person)
                    .ToListAsync();
            }
        }
    }
}
