using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductService
    {
        //CRUD  
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +" " +"Eklendi.");
            Console.WriteLine(product.CategoryId + " " + "Eklendi.");
            Console.WriteLine(product.UnitPrice + " " + "Eklendi.");
        }

       public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "Güncellendi.");
            Console.WriteLine(product.UnitsInStock + " " + "Güncellendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "Silindi");
        }
    }
}
