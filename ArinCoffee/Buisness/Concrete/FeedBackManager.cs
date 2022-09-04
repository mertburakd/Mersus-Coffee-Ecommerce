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
    public class FeedBackManager : IFeedBackService
    {

        private readonly IFeedBackDal _feedbackDal;
        public FeedBackManager(IFeedBackDal feedbackDal)
        {
            _feedbackDal = feedbackDal;
        }
        public IDataResult<List<FeedBack>> GetList()
        {
            return new SuccessDataResult<List<FeedBack>>(_feedbackDal.GetList());
        }

    }
}
