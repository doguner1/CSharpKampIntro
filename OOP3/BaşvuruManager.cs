using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BaşvuruManager
    {

        //Method injection yani bu methodun hangi kredi türü olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.
        public void BaşvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran Bilgileri Değerlendir
            //
            krediManager.Hesapla(); //Buraya konut yollarsan bellekteki konut kredisinin referansı çalışır
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }
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
