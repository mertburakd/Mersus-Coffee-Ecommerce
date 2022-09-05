using Buisness.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace WEBUI.ViewComponents
{
    public class CardItemsViewComponent : ViewComponent
    {
        private readonly ICardService _cardService;

        public CardItemsViewComponent(ICardService cardService)
        {
            _cardService = cardService;
        }

        public ViewViewComponentResult Invoke(int id)
        {
            var data = _cardService.UserCardView(id);
            return View(data.Data);
        }
    }
}
