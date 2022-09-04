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
    public class WatchManager : IWatchService
    {

        private readonly IWatchDal _watchDal;
        public WatchManager(IWatchDal watchDal)
        {
            _watchDal = watchDal;
        }
        public IDataResult<List<Watch>> GetList()
        {
            return new SuccessDataResult<List<Watch>>(_watchDal.GetList());
        }

    }
}
