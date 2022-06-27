using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doğu Guner
            GerekMusteri musteri1 = new GerekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Doğu";
            musteri1.Soyadi = "Guner";
            musteri1.MusteriNo = "111111";
            musteri1.TcNo = "123123131";

            //Doğuverse.com
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2222222";
            musteri2.SirketAdi = "Doğuverse";
            musteri2.VergiNo = "65657585";

            Musteri musteri3 = new GerekMusteri(); // Bi yerde new gördğünde referans numarası diye oku
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}

//SOLID
//Musteri sınıfı hem gerçek hem de tüzel müşterinin referansını tutabiliyor