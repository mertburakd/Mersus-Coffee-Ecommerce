using Buisness.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApiController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryApiController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("add")]
        public IActionResult Post([FromBody] Category category)
        {
            var result=_categoryService.Add(category);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Category category)
        {
           var result= _categoryService.Update(category);
            if (result.Success)
            {
                return Ok(result.Message);
            }
           return BadRequest(result.Message);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _categoryService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetList());
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryService.Get(id));
        }

    }
}
