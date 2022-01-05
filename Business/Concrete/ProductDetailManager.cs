using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Business;
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
           entity.ProductAddedTime = DateTime.Now;
           _productDetailDal.Add(entity);
           return new SuccessResult();
        }

       public IResult Update(ProductDetail entity)
       {
           BusinessRules.Run(CheckStockAmountEnough(entity.ProductDetailID));
           entity.ProductAddedTime = DateTime.Now;
           _productDetailDal.Update(entity);
           return new SuccessResult();
        }

       public IResult Delete(ProductDetail entity)
       {
           _productDetailDal.Delete(entity);
           return new SuccessResult();
       }

       private IResult CheckStockAmountEnough(int productDetailId)
       {
           var productDetail =  _productDetailDal.Get(p => p.ProductDetailID == productDetailId);
           if (productDetail.StockAmount <= 10)
           {
               //Log Atılacak SuccesResult dönülecek ve de log atılacak.
               return new ErrorResult(Messages.StockAmountNotEnough);

           }

           return new SuccessResult();
       }
   }
}
