using Buisness.Abstract;
using Business.Constants;
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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        private readonly IAdressService _adressService;
        private readonly ICardService _cardService;
        public OrderManager(IOrderDal orderDal, IAdressService adressService, ICardService cardService)
        {
            _orderDal = orderDal;
            _adressService = adressService;
            _cardService = cardService;
        }

        public IResult AddOrder(Adress adress)
        {

            List<Orders> orderList = new List<Orders>();
            _adressService.Add(adress);
            var card = _cardService.UserCard(adress.UserId);
            var adresdata = _adressService.GetUserLastAdress(adress.UserId);
            foreach (var item in card.Data)
            {
                Orders order = new Orders();
                order.AdressId = adresdata.Data.Id;
                order.CardId = item.Id;
                order.UsersId = adress.UserId;
                order.OrderTime = DateTime.Now;
                orderList.Add(order);
            }
            _orderDal.AddRange(orderList);
            foreach (var item in card.Data)
            {
                item.Status = false;
                _cardService.Update(item);
            }
            return new SuccessResult(Messages.OrderAdded);
        }

        public IDataResult<List<IGrouping<int, Card>>> GetOrders(int userId)
        {
            return new SuccessDataResult<List<IGrouping<int, Card>>>(_orderDal.GetOrders(userId));
        }

        public IDataResult<List<Orders>> GetList()
        {
            return new SuccessDataResult<List<Orders>>(_orderDal.GetList());
        }

        public IDataResult<List<IGrouping<int, Card>>> GetAllOrders()
        {
            return new SuccessDataResult<List<IGrouping<int, Card>>>(_orderDal.GetAllOrders());
        }

        public IResult Update(Orders orders)
        {
            _orderDal.Update(orders);
            return new SuccessResult(Messages.OrderUpdated);
        }

        public IResult Delete(int id)
        {
            _orderDal.Delete(_orderDal.Get(q => q.Id == id));
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<Orders> Get(int id)
        {
            return new SuccessDataResult<Orders>(_orderDal.Get(q=>q.Id==id));
        }
    }
}

