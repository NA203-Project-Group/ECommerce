using Business.Concrete;
using System;
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

            //foreach (var product in productManager.GetAll())
            //{
            //    string json = JsonConvert.SerializeObject(product, Formatting.Indented);
            //    Console.WriteLine(json);
            //}

            //Product productAdd = new Product
            //{
            //    ProductName = "Tavuk Çorbası",
            //    CategoryId = 6,
            //    UnitPrice = Convert.ToDecimal(6.50),
            //    UnitsInStock = 15
            //};
            //productManager.Add(productAdd);
            //CategoryId,CategoryName


            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                string json = JsonConvert.SerializeObject(category, Formatting.Indented);
                Console.WriteLine(json);
            }
        }

    }
}
