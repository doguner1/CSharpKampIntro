using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    internal class MyList<T>
    {
        T[] items;

        //constructor
        //Aslında bir methottur. Bu sınıfı bi yerde newlersen cons. otomatik çalışır
        public MyList()
        {
            items = new T[0]; //sınıfı newlediğim anda arry sıfır olarak otomatik newlendi sınıf içinde.
        }
        public void Add(T t)
        {
            T[] tempArray = items;                       //==> geçici dizi eski dizinin ref yerini tuttu
            
            items = new T[items.Length + 1];            //==> Dizimizin el. sayısını bir artırmak için yeni refli dizi yaptık
             
            for (int i = 0; i < tempArray.Length; i++) //==> Geçici dizimizdeki refi yani elemanları yeni dizimize aktarıyoruz.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = t;              //==> Sonda açılan yeni bir elemanlı o boşluğa yazdığımız elemanı yazdırdık.

            //Diyelim dizin 0 elemanlıydı. Add methodu ile tekrar newlediğin için sıfır elemanlı olan referansın uçtu.
            //O eski referansı birine tutturman gerek. temp geçici dizim oldu. Elemanlarımı tutuyor şuan. Sonra newledim ve eski item yok oldu.
            //Haliyle eski refi tuttuk ve yeni açtığımız refe aktarakak elemanlarımızı taşıdık.
        }

        public void Yazdir()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
