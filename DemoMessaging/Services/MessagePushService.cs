using DemoMessaging.Models;
using System.Text;
using System.Text.Json;

namespace DemoMessaging.Services
{
    public class MessagePushService
    {
        private readonly HttpClient _httpClient;
        private readonly string _messagingServiceUrl;

        public MessagePushService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _messagingServiceUrl = configuration["MessagingService:Url"];
        }

        public async Task PushMessageAsync(string message)
        {
            var requestBody = new RequestBody { message = message };
            var jsonMessage = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonMessage, Encoding.UTF8, "application/json");

            var data = await _httpClient.PostAsync($"{_messagingServiceUrl}/api/SendMessage", content);
        }
    }
}
