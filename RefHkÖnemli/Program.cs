using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefHkÖnemli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Prop prop = new Prop();
            prop.Sayi = 10;

            PropManager p
                = new PropManager();
            p.Deneme(prop); //yani buraya bellekteki numarayı yolluyoruz prop diyerek.
            //bellekteki yeri ise oluşturduğumuz sınıfta. Ve oradaki cevabı alacaktır
            //Kısaca ref numarası 101 ise diğer sınıfta 99 değer atarak 101 numaralı refe 99 atamış olduk.
            Console.WriteLine(prop.Sayi); //101 değeri(sözde ref numarası) okuduğumuz için cevap 99



            int Sayi2 = 199;

            p.Deneme2(Sayi2); //aslında biz parantez içine 199 yazmış oluyor int yüzünden
            //Diğer sınıfta sayı2 kaç olursa olsun burada 100 yazdık ve bağlantıyı yok ettik. bu yüzden 199 cevap
            Console.WriteLine(Sayi2); //199


            //int, double, bool... değer tipler 
            //değer tiplerde atamalar tamamen değeri üzerinden ve bütün bağlantı kopar
          
            //diziler, class, ,interface.... referans tipler
            //referans tiplerde atamalar referans numarası ile yapılır. Yani bellekteki adresiyle
        }
    }
}
