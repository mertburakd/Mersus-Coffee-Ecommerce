using Core.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buisness.Abstract
{
    public interface IFeedBackService
    {
        IDataResult<List<FeedBack>> GetList();
    }
}
