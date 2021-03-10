using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework_ST
{
    public class UrunContext : DbContext
    {
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Product> Urunler { get; set; }

        public UrunContext() : base("UrunConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
    }
}
