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
    public class DetailsModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public DetailsModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Appointment == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointment.FirstOrDefaultAsync(m => m.ID == id);
            if (appointment == null)
            {
                return NotFound();
            }
            else 
            {
                Appointment = appointment;
            }
            return Page();
        }
    }
}
