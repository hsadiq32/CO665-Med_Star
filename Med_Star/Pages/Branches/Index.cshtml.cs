using Med_Star.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Med_Star.Pages.Branches
{
    public class IndexModel : PageModel
    {
        private readonly Med_Star.Data.ApplicationDbContext _context;

        public IndexModel(Med_Star.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Branch> Branch { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Branch != null)
            {
                Branch = await _context.Branch.ToListAsync();
            }
        }
    }
}
