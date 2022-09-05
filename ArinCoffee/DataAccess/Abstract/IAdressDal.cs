using Core.DataAccess;
using Core.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAdressDal : IEntityRepository<Adress>
    {
        Adress LastAddress(int UserID);
    }
}
