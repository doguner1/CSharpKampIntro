using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {

        
        public void Add(Product product)
        {
            Console.WriteLine("Sepete " + product.ProductName +  " eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Sepeteki " + product.ProductName + " güncellendi");
        }

        public int Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }//Bu işlem sonrası ortaya çıkan işlemi kullanmada işe yarıyor. Dönüşüme ihtiyacın olduğunda kullanılır
        //Main sınıfında int toplamSonucu = productManager.Topla(2,3); yaparak bu sonucu başka yere dönderme aktarma yapmış olduk.
        // İşlem sonrası int verdi

        public void Topla2 (int sayi1, int sayi2)
        { 
            Console.WriteLine(sayi1 + sayi2);
        }//işini yapıyor ve bitiyor. Dönüşüm olmadığından işini yapar ve biter, kullanamazsın.



    }
}
