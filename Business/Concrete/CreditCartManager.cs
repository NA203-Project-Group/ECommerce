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
    public class CreditCartManager : ICreditCartService
    {
        private ICreditCartDal _creditCartDal;

        public CreditCartManager(ICreditCartDal creditCartDal)
        {
            _creditCartDal = creditCartDal;
        }
        public IDataResult<List<CreditCart>> GetAll()
        {
            return new SuccessDataResult<List<CreditCart>>(_creditCartDal.GetAll());
        }

        public IDataResult<CreditCart> Get(int id)
        {
            return new SuccessDataResult<CreditCart>(_creditCartDal.Get(c => c.ID == id));
        }
        public IDataResult<CreditCart> GetByCartId(int cartId)
        {
            return new SuccessDataResult<CreditCart>(_creditCartDal.Get(c => c.CartID == cartId));
        }
        public IResult Add(CreditCart entity)
        {
            _creditCartDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(CreditCart entity)
        {
            _creditCartDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(CreditCart entity)
        {
             _creditCartDal.Delete(entity);
            return new SuccessResult();
        }

    }
}
