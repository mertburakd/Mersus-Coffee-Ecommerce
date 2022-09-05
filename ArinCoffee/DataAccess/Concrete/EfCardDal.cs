using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramwork;
using Entities.Models;
using Entities.Models.DTO;
using System.Security.Claims;

namespace DataAccess.Concrete
{
    public class EfCardDal : EfEntityRepositoryBase<Card, ArinCoffeeContext>, ICardDal
    {
        public CardListSubDtoModel GetUserCardView(int id)
        {
            CardListSubDtoModel model = new CardListSubDtoModel();
            decimal TopSub;
            using (ArinCoffeeContext context = new ArinCoffeeContext())
            {
                var result = from card in context.Cards.Where(q => q.UsersId == id && q.Status == null)
                             join prod in context.Products on card.ProductId equals prod.ProductId
                             select new CardProductDtoModel
                             {
                                 MiniDescription = prod.MiniDescription,
                                 ProductId = prod.ProductId,
                                 Category = prod.Category,
                                 Description = prod.Description,
                                 Id = card.Id,
                                 ProductName = prod.ProductName,
                                 Image1 = prod.Image1,
                                 Image2 = prod.Image2,
                                 Image3 = prod.Image3,
                                 Image4 = prod.Image4,
                                 Image5 = prod.Image5,
                                 MiniImage = prod.MiniImage,
                                 Piece = card.Piece,
                                 Price = prod.Price,
                                 Status = card.Status,
                                 UsersId = card.UsersId,
                                 Weight = prod.Weight,
                             };
                foreach (var item in result)
                {
                    model.TotalPrice = model.TotalPrice + (item.Price * item.Piece);
                }
                model.CategoryProduct = result.ToList();


                return model;
            }

        }

        public int MaxGet(bool IncDec)
        {
            using (ArinCoffeeContext context = new ArinCoffeeContext())
            {
                if (IncDec==false)
                {
                    return context.Cards.Max(q => q.GroupBy) + 1;
                }
                return context.Cards.Max(q => q.GroupBy);
            }

        }
    }
}
