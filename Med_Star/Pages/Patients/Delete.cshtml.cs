using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Med_Star.Data;
using Med_Star.Models;

namespace Med_Star.Pages.Patients
{
    public class DeleteModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public DeleteModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Patient == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient.FirstOrDefaultAsync(m => m.ID == id);

            if (patient == null)
            {
                return NotFound();
            }
            else 
            {
                Patient = patient;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Patient == null)
            {
                return NotFound();
            }
            var patient = await _context.Patient.FindAsync(id);

            if (patient != null)
            {
                Patient = patient;
                _context.Patient.Remove(Patient);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
