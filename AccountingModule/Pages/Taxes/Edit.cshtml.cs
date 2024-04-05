using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccountingModule.Data;
using AccountingModule.Model;

namespace AccountingModule.Pages.Taxes
{
    public class EditModel : PageModel
    {
        private readonly AccountingModule.Data.AccountingModuleContext _context;

        public EditModel(AccountingModule.Data.AccountingModuleContext context)
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

            var tax =  await _context.Tax.FirstOrDefaultAsync(m => m.ID == id);
            if (tax == null)
            {
                return NotFound();
            }
            Tax = tax;
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

            _context.Attach(Tax).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaxExists(Tax.ID))
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

        private bool TaxExists(int id)
        {
            return _context.Tax.Any(e => e.ID == id);
        }
    }
}
