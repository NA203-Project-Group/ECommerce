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
        public IDataResult<List<CategorySub>> GetAll()
        {
            return new SuccessDataResult<List<CategorySub>>(_categorySubDal.GetAll());
        }

        public IDataResult<CategorySub> Get(int id)
        {
            return new SuccessDataResult<CategorySub>(_categorySubDal.Get(c => c.CategorySubID == id));
        }

        public IResult Add(CategorySub entity)
        {
            _categorySubDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(CategorySub entity)
        {
            _categorySubDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(CategorySub entity)
        {
            _categorySubDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
