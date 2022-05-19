using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
    //Video 2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety _ tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 3.21;
            double dolarBugun = 3.24;


            //Şart gerçekleşirse if çalışır yoksa else çalışır
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Dolar Düşmüş");
            }
            else if (dolarBugun == dolarDun)
            {
                Console.WriteLine("Dolarda değişim yok, dün ile aynı");
            }
            else
            {
                Console.WriteLine("Dolar artmış");
            }
        }
    }
}
