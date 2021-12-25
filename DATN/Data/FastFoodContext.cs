using DATN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN.Data
{
    public class FastFoodContext: DbContext
    {
        public FastFoodContext(DbContextOptions<FastFoodContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        
        public DbSet<History> Histories { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        public DbSet<Promotion> Promotions { get; set; }
    }
}
