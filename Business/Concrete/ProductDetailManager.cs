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

       public IDataResult<List<ProductDetail>> GetAll()
       {
           return new SuccessDataResult<List<ProductDetail>>(_productDetailDal.GetAll());
       }

       public IDataResult<ProductDetail> Get(int id)
       {
           return new SuccessDataResult<ProductDetail>(_productDetailDal.Get(p => p.ProductDetailID == id));
       }

       public IResult Add(ProductDetail entity)
       {
           _productDetailDal.Add(entity);
           return new SuccessResult();
        }

       public IResult Update(ProductDetail entity)
       {
           _productDetailDal.Update(entity);
           return new SuccessResult();
        }

       public IResult Delete(ProductDetail entity)
       {
           _productDetailDal.Delete(entity);
           return new SuccessResult();
        }
   }
}
