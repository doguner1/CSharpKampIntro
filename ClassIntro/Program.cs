using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
    //Video 2 devam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            // Kendi veri tipimi yazıyorum gibi düşünelim. new diyerek kurs sınıfının ref oluşturduk.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Doğu";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            // Kurs kurs kısmını program anlamazdı fakat aşağıda kurs adında bir sınıfımız, kurs adında bir veri tipimiz var ve sorun yok.
            kurs2.KursAdi = "Java#";
            kurs2.Egitmen = "A";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python#";
            kurs3.Egitmen = "B";
            kurs3.IzlenmeOrani = 70;

            Kurs[] kurslar = {kurs1, kurs2, kurs3}; //Burada kendi dizimizi kendi veri tipimizle oluşturduk

            foreach (var item in kurslar) // dizimizi foreach ile yazdık.
            {
                Console.WriteLine(item.KursAdi + " " + item.Egitmen + " " + item.IzlenmeOrani );
            }

        }
    }

    class Kurs
        //Özellik barındarın sınıfımız.
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
