using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManager = new İhtiyaçKrediManager();
            IKrediManager tasitKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseService = new DataBaseLoggerService();                      //--> Bu ve 20. satırdaki parantez içi new yazma aynı demektir, alternatifler
            ILoggerService fileLoggerService = new FileLoggerService();

            BaşvuruManager başvuruManager = new BaşvuruManager();
            başvuruManager.BaşvuruYap(new EsnaKrediManager(),new List<ILoggerService> {new DataBaseLoggerService(),new SmsLoggerService() });
            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager, tasitKrediManager };
            //başvuruManager.KrediOnBilgilendirmesiYap(krediler); -->Burada krediler diye list yaptık onu kullandık başvuru yap yerine. Yukarda ise parantez içine new List yaptık,
        }
    }


}

//İnterfaceler de o interfaceyi implement eden sınıfın referansını tutar. Üsteki koddan bu çıkar.
