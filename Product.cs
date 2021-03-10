using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ST
{
    public class Product
    {
        //değişken adını Id koymazsak birincil anahtar yapmak için üstüne [key] yazmamız gerekir.
        public int Id { get; set; } //birincil id oldugu eğer Id yazarsak varsayılan olarak anlaşılır.
        public string ProductName { get; set; }
        public double Fiyat { get; set; }
        public int StokAdeti { get; set; }

        //Category sınıfı adı ile Id adını birleştirerek yazarsak bunun anahtar oldugu varsayılan olarak anlaşılır.
        //public int CategoryId { get; set; }

        //public Category category { get; set; } //Program esnasında kullanmak için
        //public List<Tedarikci> tedarikciler { get; set; }
        
    }
}
