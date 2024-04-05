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
    public class DetailsModel : PageModel
    {
        private readonly AccountingModule.Data.AccountingModuleContext _context;

        public DetailsModel(AccountingModule.Data.AccountingModuleContext context)
        {
            _context = context;
        }

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
    }
}
