using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountingModule.Data;
using AccountingModule.Model;

namespace AccountingModule.Pages.Taxes
{
    public class DeleteModel : PageModel
    {
        private readonly AccountingModule.Data.AccountingModuleContext _context;

        public DeleteModel(AccountingModule.Data.AccountingModuleContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tax Tax { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tax = await _context.Tax.FirstOrDefaultAsync(m => m.ID == id);

            if (tax == null)
            {
                return NotFound();
            }
            else
            {
                Tax = tax;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tax = await _context.Tax.FindAsync(id);
            if (tax != null)
            {
                Tax = tax;
                _context.Tax.Remove(Tax);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
