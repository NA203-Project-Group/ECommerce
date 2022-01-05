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
    public class FavoriteManager : IFavoriteService
    {
        private IFavoriteDal _favoriteDal;

        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }

        public IDataResult<List<Favorite>> GetAll()
        {
            return new SuccessDataResult<List<Favorite>>(_favoriteDal.GetAll());
        }

        public IDataResult<Favorite> Get(int id)
        {
            return new SuccessDataResult<Favorite>(_favoriteDal.Get(f => f.ID == id));
        }

        public IResult Add(Favorite entity)
        {
            _favoriteDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Favorite entity)
        {
            _favoriteDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Favorite entity)
        {
            _favoriteDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
