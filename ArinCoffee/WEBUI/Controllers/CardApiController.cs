using Buisness.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardApiController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardApiController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost("add")]
        public IActionResult Post([FromBody] Card card)
        {
            var result = _cardService.Add(card);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] Card card)
        {
            var result = _cardService.Update(card);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _cardService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_cardService.GetList());
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            return Ok(_cardService.Get(id));
        }
        [HttpGet("getusercard")]
        public IActionResult GetUserCard(int userId)
        {
            return Ok(_cardService.UserCardView(userId));
        }
    }
}
