using Buisness.Abstract;
using Entities.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICardService _cardService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomeController(ILogger<HomeController> logger, ICardService cardService, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _cardService = cardService;
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.products = _productService.GetList().Data;
            model.categories=_categoryService.GetList().Data;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }



        public IActionResult Faq()
        {
            return View();
        }


        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult ProductDetails(int Id)
        {
            var singleProduct = _productService.Get(Id).Data;

            return View(singleProduct);
        }

        public IActionResult Story()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();

        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Wishlist()
        {
            return View();
        }

        public IActionResult MyAccount()
        {
            return View();
        }
    }
}