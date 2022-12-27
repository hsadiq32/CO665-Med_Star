using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Med_Star.Data;
using Med_Star.Models;

namespace Med_Star.Pages.Branches
{
    public class DetailsModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public DetailsModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public MedStarBranch MedStarBranch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MedStarBranch == null)
            {
                return NotFound();
            }

            var medstarbranch = await _context.MedStarBranch.FirstOrDefaultAsync(m => m.ID == id);
            if (medstarbranch == null)
            {
                return NotFound();
            }
            else 
            {
                MedStarBranch = medstarbranch;
            }
            return Page();
        }
    }
}
