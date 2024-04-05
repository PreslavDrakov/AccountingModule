using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountingModule.Model;

namespace AccountingModule.Data
{
    public class AccountingModuleContext : DbContext
    {
        public AccountingModuleContext (DbContextOptions<AccountingModuleContext> options)
            : base(options)
        {
        }

        public DbSet<AccountingModule.Model.Product> Product { get; set; } = default!;
        public DbSet<AccountingModule.Model.Tax> Tax { get; set; } = default!;
    }
}
