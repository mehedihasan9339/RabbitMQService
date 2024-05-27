using DemoMessaging.Models;
using DemoMessaging.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoMessaging.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendController : ControllerBase
    {
        private readonly MessagePushService _messagePushService;

        public SendController(MessagePushService messagePushService)
        {
            _messagePushService = messagePushService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(RequestBody model)
        {
            await _messagePushService.PushMessageAsync(model.message);
            return Ok("Message sent to messaging service.");
        }
    }
}
