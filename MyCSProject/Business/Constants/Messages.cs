using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants // core katmanında olmamasının sebebi sadece her projede ürünler olmaz. evrensel değil.
{
    public static class Messages // newlenemez
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string ProductsListed = "Ürünler başarıyla listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        internal static string ProductNameAlreadyExists = "Eklemeye çalışılan ürünün adı zaten mevcut.";
        internal static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        internal static string? AuthorizationDenied = "Yetkiniz yok.";
    }
}
