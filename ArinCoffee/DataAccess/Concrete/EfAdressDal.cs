using Core.DataAccess.EntityFramework;
using Core.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramwork;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfAdressDal : EfEntityRepositoryBase<Adress, ArinCoffeeContext>, IAdressDal
    {
        public Adress LastAddress(int UserID)
        {
            using (ArinCoffeeContext context = new ArinCoffeeContext())
            {
                return context.Adresses.OrderByDescending(q=>q.Id).First(q => q.UserId == UserID);
            }
        }
    }
}
