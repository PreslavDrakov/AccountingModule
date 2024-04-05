using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountingModule.Data;
using AccountingModule.Model;

namespace AccountingModule.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly AccountingModule.Data.AccountingModuleContext _context;

        public DetailsModel(AccountingModule.Data.AccountingModuleContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.Include(p => p.CustomerTax).Include(p => p.VendorTax).FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}
