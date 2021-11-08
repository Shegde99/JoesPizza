using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace coreSessionManagementApplication.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Orderdetails> orderdetails { get; set; }

        public DbSet<Product> Products { get; set; }
        //public DbSet<PizzaView> PizzaViews { get; set; }
        public DbSet<order> orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=supriyaadmin.database.windows.net;User Id=supadmin;Password=admi@12345678;Database=JoesPizzaDB;Trusted_Connection=False;Encrypt=True;");
        }
    }
}
