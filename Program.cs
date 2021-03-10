using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ST
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ

            UrunListeleme();
            

            Console.ReadLine();

        }

        static void UrunSil()
        {
            int id;

            UrunContext context = new UrunContext();

            Console.Write("Silmek istediğiniz ürünün id'sini giriniz : ");
            id = Convert.ToInt32(Console.ReadLine());
            var urun = context.Urunler.Find(id);

            if (urun != null)
            {
                context.Urunler.Remove(urun);
            }
            else
            {
                Console.WriteLine("Ürün bulunamadı.");
            }
            context.SaveChanges();
            Console.WriteLine();
            UrunListeleme();
        }

        static void UrunBilgiGuncelle()
        {
            UrunContext context = new UrunContext();

            while (true)
            {
                string name;
                int stokAdet;
                int id;

                Console.Write("Güncellemek istediğiniz ürünün id'sini giriniz : ");
                id = Convert.ToInt32(Console.ReadLine());

                var urun = context.Urunler.Find(id);
                if (urun != null)
                {
                    Console.WriteLine(urun.Id + " - " + urun.ProductName + " - " + urun.StokAdeti);
                }
                else
                {
                    Console.WriteLine("Girmiş olmuş ID'ye ait ürün bulunmamakta.");
                    continue;
                }

                Console.Write("Ürüne vermek istediğiniz yeni ismi giriniz : ");
                name = Console.ReadLine();
                Console.Write("Ürünün stok adetini giriniz : ");
                stokAdet = Convert.ToInt32(Console.ReadLine());

                urun.ProductName = name;
                urun.StokAdeti = stokAdet;
                Console.WriteLine("güncelleme işlemi başarıyla gerçekleşti.");
                context.SaveChanges();
                Console.WriteLine(urun.Id + " - " + urun.ProductName + " - " + urun.StokAdeti + " - " + urun.Fiyat);
            }
            
        }

        static void FiyatGuncelle()
        {
            UrunContext context = new UrunContext();

            double zam;
            int id;
            Console.Write("Fiyatını güncellemek istediğiniz ürünün ıd'sini giriniz : ");
            id = Convert.ToInt32(Console.ReadLine());

            var urun = context.Urunler.Find(id);

            Console.WriteLine(urun.Id + " " + urun.ProductName + " " + urun.StokAdeti + " " + urun.Fiyat);

            Console.Write("TL cinsinden artış miktarı gir : ");
            zam = Convert.ToDouble(Console.ReadLine());

            if (urun.StokAdeti > 0)
            {
                urun.Fiyat += zam;
                context.SaveChanges();
                Console.WriteLine(urun.Id + " " + urun.ProductName + " " + urun.StokAdeti + " " + urun.Fiyat);
            }
            else
            {
                Console.WriteLine("Ürün stokta bulunmamakta.");
            } 
            
        }

        static void UrunBulma()
        {
            while (true)
            {
                UrunContext Context = new UrunContext();
                Console.Write("Aradığınız ürünün Id'sini giriniz : ");
                int id;
                id = Convert.ToInt32(Console.ReadLine());
                var urun = Context.Urunler.Find(id);
                Console.WriteLine("Urun Id : {0}", urun.Id);
                Console.WriteLine("Urun Adı : {0}", urun.ProductName);
                Console.WriteLine("Urun Fiyat : {0}", urun.Fiyat);
                Console.WriteLine("Stok Adeti : {0}", urun.StokAdeti);
                Console.WriteLine();
            }
            
        }

        static void UrunListeleme()
        {
            UrunContext Context = new UrunContext();
            List<Product> Urunler = Context.Urunler.ToList();

            foreach (var urun in Urunler)
            {
                Console.WriteLine("Urun Id : {0}", urun.Id);
                Console.WriteLine("Urun Adı : {0}", urun.ProductName);
                Console.WriteLine("Urun Fiyat : {0}", urun.Fiyat);
                Console.WriteLine("Stok Adeti : {0}", urun.StokAdeti);
                Console.WriteLine();
            }

        }

        static void KategoriListeleme()
        {
            UrunContext Context = new UrunContext();

            List<Category> Categories = Context.Kategoriler.ToList();

            foreach (var kategori in Categories)
            {
                Console.WriteLine("Kategori Id : {0}  Kategori Ad : {1}", kategori.CategoryId, kategori.CategoryName);
            }
        }

        static void UrunEkleme()
        {
            UrunContext Context = new UrunContext();

            List<Product> Urunler = new List<Product>()
            {
                new Product(){ProductName="Samsung S4",Fiyat=2300,StokAdeti=21 },
                new Product(){ProductName="Samsung S10",Fiyat=4800,StokAdeti=34 },
                new Product(){ProductName="Iphone X",Fiyat=700,StokAdeti=12 },
            };

            foreach (var urun in Urunler)
            {
                Context.Urunler.Add(urun);
            }

            Context.SaveChanges();

            Console.WriteLine("Ürünler kaydedildi.");
        }


    }
}
