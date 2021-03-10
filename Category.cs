using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ST
{
    public class Category
    {
        // varsayılan olarak otomatik artar.
        public int CategoryId { get; set; } //kategori tablosunun birincil anahtarı olarak işaretlenir.
        public string CategoryName { get; set; }

        //public List<Product> products { get; set; } //Program esnasında kullanmak için
    }
}
