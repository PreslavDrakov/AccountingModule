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
    public class IndexModel : PageModel
    {
        private readonly AccountingModule.Data.AccountingModuleContext _context;

        public IndexModel(AccountingModule.Data.AccountingModuleContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.CustomerTax)
                .Include(p => p.VendorTax).ToListAsync();
        }
    }
}
