using Core.Results;
using Entities.Models;
using Entities.Models.DTO;
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
        IDataResult<Orders> Get(int id);
        IDataResult<List<AllOrderDto>> GetOrders(int userId);
        IDataResult<List<AllOrderDto>> GetAllOrders();
        IResult AddOrder(Adress adress);
        IResult Update(Orders orders);
        IResult Delete(int id);

    }
}
