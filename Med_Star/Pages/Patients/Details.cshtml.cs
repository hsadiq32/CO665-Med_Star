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
    public class DetailsModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public DetailsModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
