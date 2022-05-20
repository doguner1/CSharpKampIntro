using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
    //Diziler gibi. Dizilerde tanımladığın eleman sayısının dışına çıkamıyorsun. Koleksiyonda ise dizide oynama mümkün
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> kelimeler = new List<string> {"Doğu","Güner","İnönü","Malatya" };
            kelimeler.Add("Yeşilyurt");

            Console.WriteLine(kelimeler[3]);
            Console.WriteLine(kelimeler[4]);
            kelimeler.Remove("Doğu");
            Console.WriteLine(kelimeler[0]);

        }
    }
}



//ssdfsdf
//sdfsdfsdf    ==> ctlr k , ctrl c yapınca seçtiğin kısmı yoruma alıyor. Toplu yorum. Geri almak için ctrl k , ctrl u.
//sdfsdfdsf