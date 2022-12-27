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
    public class DeleteModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public DeleteModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.MedStarBranch == null)
            {
                return NotFound();
            }
            var medstarbranch = await _context.MedStarBranch.FindAsync(id);

            if (medstarbranch != null)
            {
                MedStarBranch = medstarbranch;
                _context.MedStarBranch.Remove(MedStarBranch);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
