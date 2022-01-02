using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IServiceRepositoryBase<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> Get(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}

