using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Veritabanına logger yapacak servis
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}

//Sınıf içinde sınıf yazdığımız vakit, sınıf üstünde tıkladıktan sonra ampülden move type... tıklayınca o sınıfı hızlıca bir sınıf oluşturup içine atar.