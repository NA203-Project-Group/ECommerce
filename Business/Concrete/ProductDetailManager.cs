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
   public class ProductDetailManager : IProductDetailService
   {
       private IProductDetailDal _productDetailDal;

       public ProductDetailManager(IProductDetailDal productDetailDal)
       {
           _productDetailDal = productDetailDal;
       }

       public DataResult<List<ProductDetail>> GetAll()
       {
           throw new NotImplementedException();
       }

       public DataResult<ProductDetail> Get(int id)
       {
           throw new NotImplementedException();
       }

       public Result Add(ProductDetail entity)
       {
           throw new NotImplementedException();
       }

       public Result Update(ProductDetail entity)
       {
           throw new NotImplementedException();
       }

       public Result Delete(ProductDetail entity)
       {
           throw new NotImplementedException();
       }
   }
}
