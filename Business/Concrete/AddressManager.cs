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
        private IAddressDal _adressDal;

        public AddressManager(IAddressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_adressDal.GetAll());
        }

        public IDataResult<Address> Get(int id)
        {
            return new SuccessDataResult<Address>(_adressDal.Get(a=>a.ID == 1));
        }

        public IResult Add(Address entity)
        {
            _adressDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Address entity)
        {
            _adressDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Address entity)
        {
            _adressDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<Address> GetByAddressId(int addressId)
        {
            return new SuccessDataResult<Address>(_adressDal.Get(a => a.AddressID == addressId));
        }
    }
}
