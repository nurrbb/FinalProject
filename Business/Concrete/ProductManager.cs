using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public ProductManager(InMemoryProductDal ınMemoryProductDal)
        {
        }

        public List<Product> GetAll()
        {
            
        }
    }
}
