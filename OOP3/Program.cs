using System;
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

            BaşvuruManager başvuruManager = new BaşvuruManager();
            // başvuruManager.BaşvuruYap(ihtiyaçKrediManager);
            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager, tasitKrediManager };
            başvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}

//İnterfaceler de o interfaceyi implement eden sınıfın referansını tutar. Üsteki koddan bu çıkar.
