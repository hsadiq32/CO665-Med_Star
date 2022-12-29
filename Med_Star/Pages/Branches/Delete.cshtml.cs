using Med_Star.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

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
        public Branch Branch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Branch == null)
            {
                return NotFound();
            }

            var branch = await _context.Branch.FirstOrDefaultAsync(m => m.BranchId == id);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Branch == null)
            {
                return NotFound();
            }
            var branch = await _context.Branch.FindAsync(id);

            if (branch != null)
            {
                Branch = branch;
                _context.Branch.Remove(Branch);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
