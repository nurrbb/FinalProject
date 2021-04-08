using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConcoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productmanager = new ProductManager(new EfProductDal());
            foreach (var product in productmanager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
