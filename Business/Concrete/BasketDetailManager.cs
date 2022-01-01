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
        public DataResult<List<BasketDetail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<BasketDetail> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(BasketDetail entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(BasketDetail entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(BasketDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
