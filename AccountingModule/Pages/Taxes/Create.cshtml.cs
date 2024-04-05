using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AccountingModule.Data;
using AccountingModule.Model;

namespace AccountingModule.Pages.Taxes
{
    public class CreateModel : PageModel
    {
        private readonly AccountingModule.Data.AccountingModuleContext _context;

        public CreateModel(AccountingModule.Data.AccountingModuleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tax Tax { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tax.Add(Tax);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
