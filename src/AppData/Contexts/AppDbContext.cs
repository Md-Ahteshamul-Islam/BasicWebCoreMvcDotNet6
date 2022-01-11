using AppCore.Domains.Customers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Contexts
{
    public class AppDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server =DESKTOP-64KE9LQ; Database = BaseWebDotNet6; Trusted_Connection = True;");
        }
    }
}
