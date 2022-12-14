using Core.DataAccess;
using Entities.Models;
using Entities.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICardDal : IEntityRepository<Card>
    {
        CardListSubDtoModel GetUserCardView(int id);
        int MaxGet(bool IncDec);
    }
}
