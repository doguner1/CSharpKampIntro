using System;

namespace OOP3
{
    class EsnaKrediManager : IKrediManager
    {
        public void BirŞeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }
    }
}

//İnterfaceler de o interfaceyi implement eden sınıfın referansını tutar. Üsteki koddan bu çıkar.
