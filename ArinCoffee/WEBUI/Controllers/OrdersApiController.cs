using Buisness.Abstract;
using Entities.Models;
using Entities.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WEBUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersApiController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersApiController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("add")]
        public IActionResult Post([FromBody] Adress orders)
        {
            var result = _orderService.AddOrder(orders);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Orders orders)
        {
            var result = _orderService.Update(orders);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _orderService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_orderService.GetList());
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_orderService.Get(id));
        }
        [HttpGet("getuserorders")]
        public IActionResult GetUserOrders(int userId)
        {
            return Ok(_orderService.GetOrders(userId));
        }  
        [HttpGet("getallorders")]
        public IActionResult GetAllOrders()
        {
            var orders = _orderService.GetAllOrders();
            return Ok(_orderService.GetAllOrders());
        }
    }
}
