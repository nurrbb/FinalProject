using Business.Concrete;
using System;

namespace ConcoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productmanager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productmanager.GetAll)
            {
                Console.WriteLine(product.);
            }
        }
    }
}
