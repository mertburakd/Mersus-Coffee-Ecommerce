using Buisness.Abstract;
using Entities.Models;
using Entities.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WEBUI.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private readonly ICardService _cardService;
        private readonly IAdressService _adressService;
        private readonly IOrderService _orderService;
        public ShopController(ICardService cardService,IAdressService adressService, IOrderService orderService)
        {
            _cardService = cardService;
            _adressService = adressService;
            _orderService = orderService;
        }
        [HttpPost]
        public IActionResult AddProductCard(int Productid, int Piece)
        {
            if (Piece == 0)
            {
                Piece = 1;
            }
            Card cardItem = new Card();
            cardItem.ProductId = Productid;
            cardItem.Piece = Piece;
            cardItem.UsersId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            _cardService.Add(cardItem);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Card()
        {
            return View(_cardService.UserCardView(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))).Data);
        }
        public IActionResult Checkout()
        {
            AdressViewModel newad=new AdressViewModel();
            newad.TotalPrice = _cardService.UserCardView(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))).Data.TotalPrice;
            return View(newad);
        }
        public IActionResult AddOrderAdress(Adress adress)
        {
            adress.UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            _orderService.AddOrder(adress);
            return RedirectToAction("Index","Home");
        }
        public IActionResult RemoveItem(int Id)
        {
            _cardService.Delete(Id);
            return RedirectToAction("Card", "Shop");
        }
        public IActionResult QuantCardAddDell([FromBody] ProductAddToCardDto productAddToCardDto)
        {

            var CardItem = _cardService.Get(productAddToCardDto.cardId);
            if (productAddToCardDto.Quantities == 0)
            {
                _cardService.Delete(CardItem.Data.Id);
            }
            else
            {
                CardItem.Data.Piece = productAddToCardDto.Quantities;
                _cardService.Update(CardItem.Data);
            }

            return PartialView("~/Views/Shared/PartialView/_DynamicCard.cshtml", _cardService.UserCardView(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))).Data);

        }

        public IActionResult OrderHistory()
        {
            UserProfileViewModel userdata = new UserProfileViewModel();
            userdata.allOrderDto = _orderService.GetOrders(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier))).Data;
            return View(userdata);
        }

    }
}
