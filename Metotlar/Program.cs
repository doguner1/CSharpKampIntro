using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
    // Video 3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adı = "Elma";
            urun1.Fiyatı = 12;
            urun1.Acıklama = "Amasya Elması";
            urun1.StokAdedi = 20;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adı = "Karpuz";
            urun2.Fiyatı = 13;
            urun2.Acıklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi=10;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler) // in urunler dediğinde bemim urunler adında ki dizimin her bir elemanını tek tek gez demek. Ortadaki urun
            {                             // bu diziye verilen ad demek. Yani dizi adı urun olduğundan urun kelimesi ile çağırırız (x de olur y de olur)
                                          // Urun[] de urunler verisinde bir dizi demek. Veri tipidir. String[] gibi
                Console.WriteLine(urun.Adı);

            }

            Console.WriteLine("-------------Methotlar-----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            //sepetManager.Ekle2("elma",10,"Amasya Elması"); -->> Stok adedi ekledik burası patladı  

        }
    }
}


//Dont repeat yourself - DRY