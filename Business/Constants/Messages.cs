using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages //static yapılar newlenmez kod bounca tek instance alır
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        internal static string MaintenanceTime="sistem bakımda";
        internal static string ProductListed="ürünler listelendi";
    }
}
