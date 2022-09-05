using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramwork;
using Entities.Models;
using Entities.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DataAccess.Concrete
{
    public class EfOrderDal : EfEntityRepositoryBase<Orders, ArinCoffeeContext>, IOrderDal
    {
        public void AddRange(List<Orders> order)
        {
            using (ArinCoffeeContext context = new ArinCoffeeContext())
            {
                context.Orders.AddRange(order);
                context.SaveChanges();
            }
        }

        public List<IGrouping<int, Card>> GetAllOrders()
        {
            using (ArinCoffeeContext context = new ArinCoffeeContext())
            {
                var withalldata = context.Cards.Include(e => e.Product).Include(q => q.Orders.Where(q => q.CardId == q.CardId)).ToList();
                var withGroup = withalldata.GroupBy(q => q.GroupBy).ToList();
                return withGroup;
            }
        }

        public List<IGrouping<int, Card>> GetOrders(int userId)
        {
            using (ArinCoffeeContext context = new ArinCoffeeContext())
            {
                var withalldata= context.Cards.Where(q => q.UsersId == userId && q.Status != null).Include(e => e.Product).Include(q => q.Orders.Where(q => q.UsersId == userId)).ToList();
                var withGroup = withalldata.GroupBy(q => q.GroupBy).ToList();
                return withGroup;
            }
        }
    }
}
