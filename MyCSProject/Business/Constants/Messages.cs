using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants // core katmanında olmamasının sebebi sadece her projede ürünler olmaz. evrensel değil.
{
    public static class Messages // newlenemez
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductsListed = "Ürünler Başarıyla Listelendi";
    }
}
