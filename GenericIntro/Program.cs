using GenericIntro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic olduğundan düz new ile bu sınıf newlenemez.
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Hello");
            isimler.Add("World");

            isimler.Yazdir();

            
        }
    }
}
