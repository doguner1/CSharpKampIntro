﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     interface IKrediManager
    {
        void Hesapla();
        void BirŞeyYap();
        
    }
}
//İmzanın aynı olduğu (imza = hesapla fonksyionu) ama içerisinin farklı olduğu durumlarda class değilde interface olarak kullanırız.
//İnterface methoduna dikkat. İnterface derki, eğer biri beni kullanırsa benim imzamıda kullanmak zorunda