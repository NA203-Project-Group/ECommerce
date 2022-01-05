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
    public class AddressDetailManager : IAddressDetailService
    {
        private IAddressDetailDal _addressDetailDal;

        public AddressDetailManager(IAddressDetailDal addressDetailDal)
        {
            _addressDetailDal = addressDetailDal;

        }
        public IDataResult<List<AddressDetail>> GetAll()
        {
            return new SuccessDataResult<List<AddressDetail>>(_addressDetailDal.GetAll());

        }

        public IDataResult<AddressDetail> Get(int id)
        {
            return new SuccessDataResult<AddressDetail>(_addressDetailDal.Get(a => a.AddressID == id));
        }

        public IResult Add(AddressDetail entity)
        {

            _addressDetailDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(AddressDetail entity)
        {
            _addressDetailDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(AddressDetail entity)
        {
            _addressDetailDal.Delete(entity);
            return new SuccessResult();

        }
    }
}
