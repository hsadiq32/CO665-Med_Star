using Med_Star.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Med_Star.Pages.Branches
{
    public class DetailsModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public DetailsModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Branch Branch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Branch == null)
            {
                return NotFound();
            }

            var branch = await _context.Branch
                .Include(b => b.Doctors)
                    .ThenInclude(d => d.Person)
                .FirstOrDefaultAsync(m => m.BranchId == id);
            if (branch == null)
            {
                return NotFound();
            }
            else
            {
                Branch = branch;
            }
            return Page();
        }
    }
}
