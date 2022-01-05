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
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll());
        }

        public IDataResult<Payment> Get(int id)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(p => p.PaymentID == id));

        }

        public IResult Add(Payment entity)
        {
           _paymentDal.Add(entity);
           return new SuccessResult();
        }

        public IResult Update(Payment entity)
        {
            _paymentDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Payment entity)
        {
            _paymentDal.Add(entity);
            return new SuccessResult();
        }
    }
}
