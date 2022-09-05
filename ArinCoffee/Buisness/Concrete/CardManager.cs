using Buisness.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Models;
using Entities.Models.DTO;
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

        public IResult Add(Card card)
        {
            var carddata = _cardDal.GetOne(q => q.UsersId == card.UsersId && q.Status == null && q.ProductId == card.ProductId);
            var cardInc = _cardDal.GetOne(q => q.UsersId == card.UsersId && q.Status == null);
            if (carddata != null)
            {
                carddata.Piece = carddata.Piece + card.Piece;
                _cardDal.Update(carddata);
            }
            else
            {
                if (cardInc==null)
                {
                    card.GroupBy = _cardDal.MaxGet(false);
                }
                else
                {
                    card.GroupBy = _cardDal.MaxGet(true);
                }
                _cardDal.Add(card);
            }
            return new SuccessResult(Messages.CardAdd);
        }

        public IResult Delete(int id)
        {
            _cardDal.Delete(_cardDal.Get(q => q.Id == id && q.Status == null));
            return new SuccessResult(Messages.CardDeleted);
        }

        public IDataResult<Card> Get(int id)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(q => q.Id == id && q.Status == null));
        }

        public IDataResult<List<Card>> GetList()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetList(q => q.Status == null));
        }

        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult(Messages.CardUpdated);
        }

        public IDataResult<List<Card>> UserCard(int id)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetList(q => q.UsersId == id && q.Status == null));
        }

        public IDataResult<CardListSubDtoModel> UserCardView(int id)
        {
            return new SuccessDataResult<CardListSubDtoModel>(_cardDal.GetUserCardView(id));
        }
    }
}
