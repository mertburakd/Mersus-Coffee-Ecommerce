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
    public class CardManager : ICardService
    {
        private readonly ICardDal _cardDal;
        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }
        public IDataResult<List<Card>> GetList()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetList());
        }
    }
}
