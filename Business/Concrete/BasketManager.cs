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
        public DataResult<List<Basket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<Basket> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(Basket entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(Basket entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Basket entity)
        {
            throw new NotImplementedException();
        }
    }
}
