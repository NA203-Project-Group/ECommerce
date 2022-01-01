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
        public DataResult<List<CreditCart>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<CreditCart> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(CreditCart entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(CreditCart entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(CreditCart entity)
        {
            throw new NotImplementedException();
        }
    }
}
