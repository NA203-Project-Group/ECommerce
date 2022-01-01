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
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public DataResult<List<City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<City> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(City entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(City entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
