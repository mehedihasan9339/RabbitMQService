using Microsoft.AspNetCore.Connections;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMQService.Helper
{
    public class RabbitMqService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;

        public RabbitMqService(IConfiguration configuration)
        {
            var factory = new ConnectionFactory()
            {
                HostName = configuration["RabbitMQ:HostName"],
                UserName = configuration["RabbitMQ:UserName"],
                Password = configuration["RabbitMQ:Password"]
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
        }

        public void SendMessage(string queueName, string message)
        {
            _channel.QueueDeclare(queue: queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var body = Encoding.UTF8.GetBytes(message);

            _channel.BasicPublish(exchange: "",
                                 routingKey: queueName,
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine($" [x] Sent {message}");
        }

        public void Dispose()
        {
            _channel.Close();
            _connection.Close();
        }
    }
}
