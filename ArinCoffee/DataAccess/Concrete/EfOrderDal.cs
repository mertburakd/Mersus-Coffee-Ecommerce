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

        public List<AllOrderDto> GetAllOrders()
        {
            List<AllOrderDto> allOrders = new List<AllOrderDto>();
            using (ArinCoffeeContext context = new ArinCoffeeContext())
            {
                var withalldata = context.Cards.Include(e => e.Product).Include(q => q.Orders.Where(q => q.CardId == q.CardId)).ToList();
                var withGroup = withalldata.GroupBy(q => q.GroupBy).ToList();
                foreach (var item in withGroup)
                {
                    AllOrderDto allOrderDto = new AllOrderDto();
                    allOrderDto.Id = item.Key;
                    var carddata = withalldata.Where(q => q.GroupBy == item.Key).ToList();
                    List<Card> newcardlist = new List<Card>();
                    foreach (var x in carddata)
                    {
                        var product = context.Products.FirstOrDefault(q => q.ProductId == x.ProductId);
                        Card newcard = new Card();
                        List<Orders> neworderlist = new List<Orders>();
                        Product newprod = new Product
                        {
                            ProductId = x.ProductId,
                            Category = product.Category,
                            Description = product.Description,
                            Image1 = product.Image1,
                            Image2 = product.Image2,
                            Image3 = product.Image3,
                            Image4 = product.Image4,
                            Image5 = product.Image5,
                            ListArea = product.ListArea,
                            MiniImage = product.MiniImage,
                            Price = product.Price,
                            Status = product.Status,
                            MiniDescription = product.MiniDescription,
                            ProductName = product.ProductName,
                            Weight = product.Weight,
                        };
                       
                        newcard.Status = x.Status;
                        newcard.ProductId = x.ProductId;
                        newcard.UsersId = x.UsersId;
                        newcard.Id = x.Id;
                        newcard.GroupBy = x.GroupBy;
                        newcard.Piece = x.Piece;
                        newcard.Product = newprod;
                        foreach (var ord in x.Orders)
                        {
                            Orders neworder = new Orders();
                            neworder.UsersId = ord.UsersId;
                            neworder.AdressId = ord.AdressId;
                            neworder.CardId = ord.CardId;
                            neworder.EndTime = ord.EndTime;
                            neworder.OrderTime = ord.OrderTime;
                            neworder.Id = ord.Id;

                            neworderlist.Add(neworder);
                        }
                        newcard.Orders = neworderlist;
                        newcardlist.Add(newcard);
                    }
                    allOrderDto.card = newcardlist;
                    allOrders.Add(allOrderDto);
                }
                return allOrders;
            }
        }

        public List<AllOrderDto> GetOrders(int userId)
        {
        
                List<AllOrderDto> allOrders = new List<AllOrderDto>();
                using (ArinCoffeeContext context = new ArinCoffeeContext())
                {
                    var withalldata = context.Cards.Where(q => q.UsersId == userId && q.Status != null).Include(e => e.Product).Include(q => q.Orders.Where(q => q.UsersId == userId)).ToList();
                    var withGroup = withalldata.GroupBy(q => q.GroupBy).ToList();
                    foreach (var item in withGroup)
                    {
                        AllOrderDto allOrderDto = new AllOrderDto();
                        allOrderDto.Id = item.Key;
                        var carddata = withalldata.Where(q => q.GroupBy == item.Key).ToList();
                        List<Card> newcardlist = new List<Card>();
                        foreach (var x in carddata)
                        {
                            var product = context.Products.FirstOrDefault(q => q.ProductId == x.ProductId);
                            Card newcard = new Card();
                            List<Orders> neworderlist = new List<Orders>();
                            Product newprod = new Product
                            {
                                ProductId = x.ProductId,
                                Category = product.Category,
                                Description = product.Description,
                                Image1 = product.Image1,
                                Image2 = product.Image2,
                                Image3 = product.Image3,
                                Image4 = product.Image4,
                                Image5 = product.Image5,
                                ListArea = product.ListArea,
                                MiniImage = product.MiniImage,
                                Price = product.Price,
                                Status = product.Status,
                                MiniDescription = product.MiniDescription,
                                ProductName = product.ProductName,
                                Weight = product.Weight,
                            };

                            newcard.Status = x.Status;
                            newcard.ProductId = x.ProductId;
                            newcard.UsersId = x.UsersId;
                            newcard.Id = x.Id;
                            newcard.GroupBy = x.GroupBy;
                            newcard.Piece = x.Piece;
                            newcard.Product = newprod;
                            foreach (var ord in x.Orders)
                            {
                                Orders neworder = new Orders();
                                neworder.UsersId = ord.UsersId;
                                neworder.AdressId = ord.AdressId;
                                neworder.CardId = ord.CardId;
                                neworder.EndTime = ord.EndTime;
                                neworder.OrderTime = ord.OrderTime;
                                neworder.Id = ord.Id;

                                neworderlist.Add(neworder);
                            }
                            newcard.Orders = neworderlist;
                            newcardlist.Add(newcard);
                        }
                        allOrderDto.card = newcardlist;
                        allOrders.Add(allOrderDto);
                    }
                    return allOrders;
                }
        }
    }
}
