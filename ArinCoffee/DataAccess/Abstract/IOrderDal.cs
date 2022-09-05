using Core.DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entites;
using Entities.Models.DTO;

namespace DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Orders>
    {
        void AddRange(List<Orders> order);
        public List<IGrouping<int, Card>> GetOrders(int userId);
        public List<IGrouping<int, Card>> GetAllOrders();
    }
}
