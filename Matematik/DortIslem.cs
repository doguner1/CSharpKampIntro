using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Ekle(int x,int y)
        {
            int toplam = x + y;
            Console.WriteLine("Toplamları: " + toplam);
        }

        public void Cikarma(int x, int y)
        {
            int cikarma = x - y;
            Console.WriteLine("Farkları: " + cikarma);
        }
    }
}
