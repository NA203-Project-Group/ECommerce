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
        public DataResult<List<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<Comment> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
