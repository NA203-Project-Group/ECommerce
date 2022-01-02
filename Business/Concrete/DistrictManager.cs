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
   public class DistrictManager : IDistrictService
   {
       private IDistrictDal _districtDal;

       public DistrictManager(IDistrictDal districtDal)
       {
           _districtDal = districtDal;
       }

       public IDataResult<List<District>> GetAll()
       {
           return new SuccessDataResult<List<District>>(_districtDal.GetAll());
       }

       public IDataResult<District> Get(int id)
       {
           return new SuccessDataResult<District>(_districtDal.Get(d => d.DistrictID == id));
       }

       public IResult Add(District entity)
       {
           _districtDal.Add(entity);
           return new SuccessResult();
        }

       public IResult Update(District entity)
       {
           _districtDal.Update(entity);
           return new SuccessResult();
        }

       public IResult Delete(District entity)
       {
           _districtDal.Delete(entity);
           return new SuccessResult();
        }
   }
}
