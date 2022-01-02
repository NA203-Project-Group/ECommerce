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
    public class BasketManager : IBasketService
    {
        private IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }
        public IDataResult<List<Basket>> GetAll()
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll());
        }

        public IDataResult<Basket> Get(int id)
        {
            return new SuccessDataResult<Basket>(_basketDal.Get(b => b.BasketID == id));
        }

        public IResult Add(Basket entity)
        {
            _basketDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Basket entity)
        {
            _basketDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Basket entity)
        {
            _basketDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
