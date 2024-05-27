using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RabbitMQService.Helper;
using RabbitMQService.Models;

namespace RabbitMQService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly RabbitMqService _rabbitMqService;

        public MessageController(RabbitMqService rabbitMqService)
        {
            _rabbitMqService = rabbitMqService;
        }

        [HttpPost("/api/SendMessage")]
        [AllowAnonymous]
        public IActionResult SendMessage(RequestBody model)
        {
            _rabbitMqService.SendMessage("myQueue", model.message);
            return Ok("Message sent successfully.");
        }
    }
}
