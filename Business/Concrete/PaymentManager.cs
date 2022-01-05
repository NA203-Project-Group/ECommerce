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
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;
        private IAddressDetailDal _addressDetailDal;

        public PaymentManager(IPaymentDal paymentDal, IAddressDetailDal addressDetailDal)
        {
            _paymentDal = paymentDal;
            _addressDetailDal = addressDetailDal;

        }
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
            BusinessRules.Run(CheckOrderDistrict(entity));
            _paymentDal.Add(entity);
           return new SuccessResult();
        }

        public IResult Update(Payment entity)
        {
            BusinessRules.Run(CheckOrderDistrict(entity));
            _paymentDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Payment entity)
        {
            _paymentDal.Delete(entity);
            return new SuccessResult();
        }

        private IResult CheckOrderDistrict(Payment payment)
        {
            var paymentPrice = payment.TotalPrice;
            var addressDetail =  _addressDetailDal.Get(a => a.AddressID == payment.AddressID);

            if (addressDetail.DistrictID == 1 && paymentPrice <= 30)
            {
                return new ErrorResult(Messages.MinPriceThisDistrict);
            }

            return new SuccessResult();
        }


    }
}

