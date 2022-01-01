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

       public DataResult<List<District>> GetAll()
       {
           throw new NotImplementedException();
       }

       public DataResult<District> Get(int id)
       {
           throw new NotImplementedException();
       }

       public Result Add(District entity)
       {
           throw new NotImplementedException();
       }

       public Result Update(District entity)
       {
           throw new NotImplementedException();
       }

       public Result Delete(District entity)
       {
           throw new NotImplementedException();
       }
   }
}
