using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = " Masa ";
            product1.CategoryId = 2;
            product1.UnitPrice = 213;
            product1.UnitsStock = 44;

            Product product2 = new Product { Id = 2, ProductName = "Kalem", CategoryId = 1, UnitPrice = 20, UnitsStock = 200 }; // böylede yazılabilir.
        }
    }
}
