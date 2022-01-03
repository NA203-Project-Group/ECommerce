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
    public class AddressManager : IAddressService
    {
        private IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll());
        }

        public IDataResult<Address> Get(int id)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(a=>a.ID == id));
        }

        public IResult Add(Address entity)
        {
            _addressDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Address entity)
        {
            _addressDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Address entity)
        {
            _addressDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Address> GetByAddressId(int addressId)
        {
            throw new NotImplementedException();
        }
    }
}
