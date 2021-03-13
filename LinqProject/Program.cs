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
                new Product{ProductId=1, CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=8800,UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=8800,UnitsInStock=3},
                new Product{ProductId=3, CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=6000,UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=5, CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitsInStock=0}
            };




            //Test(products);

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AcsDescTest(products);

            //Single Line Query
            //Başka bir formatta yazımı:
            //ClassicLinqTest(products);

            //Join
            JoinTest(categories, products);

        }

        private static void JoinTest(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0}---{1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 8000
                         orderby p.UnitPrice descending, p.ProductName descending
                         select new ProductDto { ProductName = p.ProductName, ProductId = p.ProductId, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AcsDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            //ProductName'inde 'top' içerenlerin listesini oluşturur.
            //OrderByDescending: UnitPrice'a göre azalan şekilde sıralama yapar.
            //ThenByDescending: UnitPrice'sı eşit olanlar varsa onları da ProductName göre azalan şekilde (Z'den A'ya) listeler.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top")); //Liste döner. Product Name'inde "top" içerenlerin listesini döner.
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 5);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acerrr Laptop");//Bool döner. Arama yapmayı sağlar.
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq---------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

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
