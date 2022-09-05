using Buisness.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Security.Claims;
using WEBUI.JwtEntities;

namespace WEBUI.ViewComponents
{
    public class CardViewComponent : ViewComponent
    {
        private readonly ICardService _cardService;

        public CardViewComponent(ICardService cardService)
        {
            _cardService = cardService;
        }

        public ViewViewComponentResult Invoke(int id)
        {
          var data=  _cardService.UserCard(id);
            return View(data.Data);
        }
    }
}
