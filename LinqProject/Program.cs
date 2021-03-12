using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    CategoryId=1,
                    CategoryName="Bilgisayar"
                },
                new Category
                {
                    CategoryId=1,
                    CategoryName="Telefon"
                }
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId=3, CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=6000,UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=5, CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitsInStock=0}
            };

            Console.WriteLine("Algoritmik------------------");
            foreach ( var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock>3)
                {
                Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq---------------------");

            var result = products.Where(p=>p.UnitPrice>5000 && p.UnitsInStock>3 );

            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }


        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }

            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
           return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
        //Where arka planda şartlara uyan elemanları bir liste haline getiriyor. 
        //Array döndürdüğü için sonuna listelemesi için ToList(); eklemek gerekiyor



    }
}
