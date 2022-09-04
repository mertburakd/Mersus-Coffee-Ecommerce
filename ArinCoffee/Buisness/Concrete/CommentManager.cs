using Buisness.Abstract;
using Core.Results;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buisness.Concrete
{
    public class CommentManager: ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public IDataResult<List<Comment>> GetList()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetList());
        }

    }
}
