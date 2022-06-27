using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //
    internal class GerekMusteri: Musteri  //Sen bir Müşterisin. Bu olara miras yani inheritance denir 
    {                                   //-> Gercek müşteri bir müşteri demektir. Müşteride olan her şey burada da vardır demek
 
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}


//Bu sınıf ile diğer Tüzel sınıftaki ortak özellikleri inheritance özelliği ile tek sınıfa koyup
//miras aldırdık. Kendine ait ait özelliklerini ise kensi sınıfına yazdık