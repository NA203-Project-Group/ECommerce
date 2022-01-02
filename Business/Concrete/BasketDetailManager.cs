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
    public class BasketDetailManager : IBasketDetailService
    {
        private IBasketDetailDal _basketDetailDal;

        public BasketDetailManager(IBasketDetailDal basketDetailDal)
        {
            _basketDetailDal = basketDetailDal;
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
    }
}
