using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
    //Video 2 devam.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array - dizi (dinamk olarak sıralama, sergileme).

            string[] kurslar = new string[] { "A eleman", "B elaman", "C eleman" };


            //1 den başla, 10 a kadar 1er artarak ilerle. 10 olduğunda çıkacak çalışmayacak
            for (int i = 0; i <kurslar.Length ; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("---------------------------------------------------");

            // for ile aynı çalışan, farklı yazılım şeklindeki döngü
            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
