using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Coorporate
    internal class TuzelMusteri:Musteri  //Sen bir Müşterisin. Bu olara miras yani inheritance denir 
    {                                   //-> Tüzel müşteri bir müşteri demektir. Müşteride olan her şey burada da vardır demek
      
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}


//Bu sınıf ile diğer müşterisınıftaki ortak özellikleri inheritance özelliği ile tek sınıfa koyup
//miras aldırdık. Kendine ait ait özelliklerini ise kensi sınıfına yazdık