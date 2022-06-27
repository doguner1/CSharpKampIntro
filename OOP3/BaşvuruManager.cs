using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BaşvuruManager
    {
        public void BaşvuruYap(IKrediManager krediManager)
        {
            //Başvuran Bilgileri Değerlendir
            //
            krediManager.Hesapla(); //Buraya konut yollarsan bellekteki konut kredisinin referansı çalışır
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
