using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };

            Product product3 = new Product { Id = 4, CategoryId = 65, UnitsInStock = 25, ProductName = "Telefon", UnitPrice = 8000 };


            //PascalCase   //camelCase
            ProductService productService = new ProductService();
            productService.Add(product1);
            productService.Update(product2);
            productService.Delete(product3);
            
        }
    }
}
