using Core.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Buisness.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Orders>> GetList();
        IDataResult<List<IGrouping<int, Card>>> GetOrders(int userId);
        IDataResult<List<IGrouping<int, Card>>> GetAllOrders();
        IResult AddOrder(Adress adress);
    }
}
