using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ST
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<UrunContext>
    {
        protected override void Seed(UrunContext context)
        {

            List<Product> urunler = new List<Product>()
            {
                new Product() {ProductName = "Samsung S5",Fiyat = 1200, StokAdeti = 23},
                new Product() {ProductName = "Samsung S7",Fiyat=1430,StokAdeti = 41},
                new Product() {ProductName = "Iphone X", Fiyat = 8000,StokAdeti=43},
                new Product() {ProductName = "Samsung S20",Fiyat=9230,StokAdeti = 41},
                new Product() {ProductName = "Iphone 8", Fiyat = 6000,StokAdeti=43}
            };

            List<Category> categories = new List<Category>()
            {
                new Category() {CategoryName = "Elektronik"},
                new Category() {CategoryName = "Ev aleti"},
                new Category() {CategoryName = "Mobilya"}
            };

            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);
            }
            foreach (var kategori in categories)
            {
                context.Kategoriler.Add(kategori);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
