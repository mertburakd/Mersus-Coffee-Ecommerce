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
    public interface ICardService
    {
        IDataResult<List<Card>> GetList();
        IDataResult<Card> Get(int id);
        IDataResult<List<Card>> UserCard(int id);
        IResult Add(Card card);
        IResult Delete(int id);
        IResult Update(Card card);
        IDataResult<CardListSubDtoModel> UserCardView(int id);
    }
}
