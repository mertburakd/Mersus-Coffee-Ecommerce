﻿using Buisness.Abstract;
using Entities.Models;
using Entities.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;
using WEBUI.JwtEntities;

namespace WEBUI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        private UserManager<CustomIdentityUser> _userManager;
        private readonly IWebHostEnvironment _env2;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly ICategoryService _categoryService;

        public AdminController
            (UserManager<CustomIdentityUser> userManager, IWebHostEnvironment env2, IProductService productService, IOrderService orderService, ICategoryService categoryService)
        {
            _userManager = userManager;
            _env2 = env2;
            _productService = productService;
            _orderService = orderService;
            _categoryService = categoryService;
        }


        public async Task<IActionResult> Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.products = _productService.GetList().Data;
            model.orders = _orderService.GetList().Data;
            model.categories = _categoryService.GetList().Data;
            return View(model);
        }
       
        public IActionResult CategoryDetails(int id)
        {
            return View(_categoryService.Get(id));
        }
        public IActionResult CategoryAdd()
        {
            return View();
        }     
        public IActionResult CategoryDeleted(int id)
        {
            _categoryService.Delete(id);
            return RedirectToAction("", "Admin");
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction("Index", "Admin");
        }
        public IActionResult CategoryEdit(Category category)
        {
            _categoryService.Update(category);
            return RedirectToAction("Index", "Admin");
        }
 
        public IActionResult ProductAdd()
        {
       
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            _productService.Add(product);
            return RedirectToAction("Index", "Admin");
        }


        public IActionResult ProductEdit(int Id)
        {
            return View(_productService.Get(Id));
        }
      
        public IActionResult DeleteProduct(int Id)
        {
            _productService.Delete(Id);
                return RedirectToAction("", "Admin");
        }
    

        [HttpPost("ProductEdit")]
        public IActionResult ProductEdit(Product product, IFormFile ourFileMini, IFormFile ourFile, IFormFile ourFile2, IFormFile ourFile3, IFormFile ourFile4, IFormFile ourFile5)
        {

            var ProductGet = _productService.Get(product.ProductId).Data;
            if (ourFileMini != null)
            {
                if (ProductGet.MiniImage != null)
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/menu/", ProductGet.MiniImage));
                }
                Bitmap Pic = new Bitmap(ourFile.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/menu/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                ProductGet.MiniImage = resimAdi;
            }
            if (ourFile != null)
            {
                if (ProductGet.Image1 != null)
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/", ProductGet.Image1));
                }
                Bitmap Pic = new Bitmap(ourFile.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                ProductGet.Image1 = resimAdi;
            }

            if (ourFile2 != null)
            {
                if (ProductGet.Image2 != null)
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/", ProductGet.Image2));
                }
                Bitmap Pic = new Bitmap(ourFile2.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile2.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                ProductGet.Image2 = resimAdi;
            }

            if (ourFile3 != null)
            {
                if (ProductGet.Image3 != null)
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/", ProductGet.Image3));
                }
                Bitmap Pic = new Bitmap(ourFile3.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile3.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                ProductGet.Image3 = resimAdi;

            }

            if (ourFile4 != null)
            {
                if (ProductGet.Image4 != null)
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/", ProductGet.Image4));
                }
                Bitmap Pic = new Bitmap(ourFile4.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile4.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                ProductGet.Image4 = resimAdi;
            }

            if (ourFile5 != null)
            {
                if (ProductGet.Image5 != null)
                {
                    System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/", ProductGet.Image5));
                }
                Bitmap Pic = new Bitmap(ourFile4.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile4.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/shop/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                ProductGet.Image5 = resimAdi;
            }

            ProductGet.Status = product.Status;
            ProductGet.Cards = product.Cards;
            ProductGet.ProductName = product.ProductName;
            ProductGet.Category = product.Category;
            ProductGet.Description = product.Description;
            ProductGet.Price = product.Price;
            ProductGet.MiniDescription = product.MiniDescription;
            ProductGet.Weight = product.Weight;

            _productService.Update(ProductGet);

            return RedirectToAction("", "Admin");
        }

    }
}
