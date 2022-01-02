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
   public class CategoryManager :ICategoryService
   {
       private ICategoryDal _categoryDal;

       public CategoryManager(ICategoryDal categoryDal)
       {
           _categoryDal = categoryDal;
       }
        public IDataResult<List<Category>> GetAll()
       {
           return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
       }

       public IDataResult<Category> Get(int id)
       {
           return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id));
       }

       public IResult Add(Category entity)
       {
           _categoryDal.Add(entity);
           return new SuccessResult();
        }

       public IResult Update(Category entity)
       {
           _categoryDal.Update(entity);
           return new SuccessResult();
        }

       public IResult Delete(Category entity)
       {
           _categoryDal.Delete(entity);
           return new SuccessResult();
        }
   }
}
