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
    public class CategorySubManager : ICategorySubService
    {
        private ICategorySubDal _categorySubDal;

        public CategorySubManager(ICategorySubDal categorySubDal)
        {
            _categorySubDal = categorySubDal;
        }
        public DataResult<List<CategorySub>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<CategorySub> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(CategorySub entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(CategorySub entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(CategorySub entity)
        {
            throw new NotImplementedException();
        }
    }
}
