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

            foreach (var product in productManager.GetAll().Data)
            {
                string json = JsonConvert.SerializeObject(product, Formatting.Indented);
                Console.WriteLine(json);
            }


            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                string json = JsonConvert.SerializeObject(category, Formatting.Indented);
                Console.WriteLine(json);
            }
        }

    }
}
