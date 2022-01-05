using Business.Concrete;
using System;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Newtonsoft.Json;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll().Data)
            //{
            //    string json = JsonConvert.SerializeObject(product, Formatting.Indented);
            //    Console.WriteLine(json);
            //}

            Product product = new Product
            {
                ProductImage = "yazıolı",
                UnitPrice = 199,
                CategoryID = 1,
                
            };
            productManager.Add(product);

            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            //foreach (var category in categoryManager.GetAll().Data)
            //{
            //    string json = JsonConvert.SerializeObject(category, Formatting.Indented);
            //    Console.WriteLine(json);
            //}
        }

    }
}
