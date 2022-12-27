using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Med_Star.Data;
using Med_Star.Models;

namespace Med_Star.Pages.Branches
{
    public class EditModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public EditModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MedStarBranch MedStarBranch { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MedStarBranch == null)
            {
                return NotFound();
            }

            var medstarbranch =  await _context.MedStarBranch.FirstOrDefaultAsync(m => m.ID == id);
            if (medstarbranch == null)
            {
                return NotFound();
            }
            MedStarBranch = medstarbranch;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MedStarBranch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedStarBranchExists(MedStarBranch.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MedStarBranchExists(int id)
        {
          return _context.MedStarBranch.Any(e => e.ID == id);
        }
    }
}
