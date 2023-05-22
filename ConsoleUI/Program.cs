// See https://aka.ms/new-console-template for more information
using Bussines.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello, World!");

            ProductManager ProductManager = new ProductManager(new EfProductDal());
            foreach (var product in ProductManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}