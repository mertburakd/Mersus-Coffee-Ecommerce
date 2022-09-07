using Buisness.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;

namespace WEBUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductApiController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("add")]
        public IActionResult Post([FromBody] Product product, IFormFile ourFileMini, IFormFile ourFile, IFormFile ourFile2, IFormFile ourFile3, IFormFile ourFile4, IFormFile ourFile5)
        {
            if (ourFileMini != null)
            {

                Bitmap Pic = new Bitmap(ourFile.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/menu/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                product.MiniImage = resimAdi;
            }
            if (ourFile != null)
            {

                Bitmap Pic = new Bitmap(ourFile.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                product.Image1 = resimAdi;
            }

            if (ourFile2 != null)
            {
                Bitmap Pic = new Bitmap(ourFile2.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile2.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                product.Image2 = resimAdi;
            }

            if (ourFile3 != null)
            {
                Bitmap Pic = new Bitmap(ourFile3.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile3.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                product.Image3 = resimAdi;

            }

            if (ourFile4 != null)
            {
                Bitmap Pic = new Bitmap(ourFile4.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile4.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                product.Image4 = resimAdi;
            }

            if (ourFile5 != null)
            {
                Bitmap Pic = new Bitmap(ourFile4.OpenReadStream());
                string resimAdi = (Path.GetFileName(ourFile4.FileName) + "_" + Guid.NewGuid().ToString("N") + ".jpeg");
                Bitmap buyuk = new Bitmap(Pic, 900, 500);
                buyuk.Save(Path.Combine(Directory.GetCurrentDirectory(), "~/assets/images/products/" + resimAdi), ImageFormat.Jpeg);
                buyuk.Dispose();
                product.Image5 = resimAdi;
            }


           var result= _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Product product, IFormFile ourFileMini, IFormFile ourFile, IFormFile ourFile2, IFormFile ourFile3, IFormFile ourFile4, IFormFile ourFile5)
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
            ProductGet.Category = product.Category;
           var result= _productService.Update(ProductGet);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
           var result= _productService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetList());
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_productService.Get(id));
        }

    }
}
