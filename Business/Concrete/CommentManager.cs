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
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public IDataResult<Comment> Get(int id)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(c=>c.CommentID == id));
        }

        public IResult Add(Comment entity)
        {
            _commentDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Comment entity)
        {
            _commentDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Comment entity)
        {
            _commentDal.Delete(entity);

            return new SuccessResult();
        }
    }
}
