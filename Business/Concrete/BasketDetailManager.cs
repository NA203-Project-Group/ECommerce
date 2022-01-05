using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BasketDetailManager : IBasketDetailService
    {
        private IBasketDetailDal _basketDetailDal;
        private IProductDetailDal _productDetailDal;

        public BasketDetailManager(IBasketDetailDal basketDetailDal, IProductDetailDal productDetailDal)
        {
            _basketDetailDal = basketDetailDal;
            _productDetailDal = productDetailDal;
        }
        public IDataResult<List<BasketDetail>> GetAll()
        {
            return new SuccessDataResult<List<BasketDetail>>(_basketDetailDal.GetAll());
        }

        public IDataResult<BasketDetail> Get(int id)
        {
            return new SuccessDataResult<BasketDetail>(_basketDetailDal.Get(bD => bD.BasketDetailID == id));
        }

        public IResult Add(BasketDetail entity)
        {
           _basketDetailDal.Add(entity);
           return new SuccessResult();
        }

        public IResult Update(BasketDetail entity)
        {

            _basketDetailDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(BasketDetail entity)
        {
            _basketDetailDal.Delete(entity);
            return new SuccessResult();
        }

        private IResult CheckQuantityCount(BasketDetail basketDetail)
        {
            var productDetail =  _productDetailDal.Get(p => p.ProductID == basketDetail.ProductID);
            if (productDetail.StockAmount > basketDetail.Quantity)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
