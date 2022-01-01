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

        public DataResult<List<Address>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<Address> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(Address entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(Address entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
