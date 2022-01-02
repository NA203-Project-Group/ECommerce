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

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IDataResult<City> Get(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c => c.CityID == id));
        }

        public IResult Add(City entity)
        {
            _cityDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(City entity)
        {
            _cityDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(City entity)
        {
            _cityDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
