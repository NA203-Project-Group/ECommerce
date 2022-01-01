using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal; 

        public ProductManager(IProductDal productDal) 
        {
            _productDal = productDal;
        }

        public DataResult<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
