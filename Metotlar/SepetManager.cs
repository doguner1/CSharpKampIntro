using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        // Manager gibi sınıflar bir operasyon tutuyor, yabi operasyon sınıflarıdır.
        // Sınıflar ve methot isimlerin başları büyük olması gelenekseldir.

        public void Ekle(Urun urun) //ilki tipi ikincisi yani küçük urun ise isimlendirmede, çağırma da kullanmak için.
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adı);
        }

        public void Ekle2(string urunAdi, double fiyat, string aciklama, int stokAdedi) //Bunun doğru bir kullanım olmamasının nedeni, yeni bir madde geldiğinde
        {                                                                // yazdığın tüm sayfalar patlıyor. Bu parimetre eksik hatası veriyorlar
            Console.WriteLine("Sepete eklendi: " + urunAdi);
        }
    }
}
