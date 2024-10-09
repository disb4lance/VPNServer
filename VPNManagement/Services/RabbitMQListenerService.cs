using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using Service.Contract;
using System.Text;
using Newtonsoft.Json;
using Entities.Models;


namespace Services
{
    public class RabbitMQListenerService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;

        public RabbitMQListenerService()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            // Настройка очереди
            _channel.QueueDeclare(queue: "vpn_queue", durable: false, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueBind(queue: "vpn_queue", exchange: "vpn_exchange", routingKey: "user.registered");
        }

        public void StartListening()
        {
            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($"Received message: {message}");

                // Обработка сообщения
                HandleMessage(message);
            };
            _channel.BasicConsume(queue: "vpn_queue", autoAck: true, consumer: consumer);
        }

        private void HandleMessage(string message)
        {
            var eventMessage = JsonConvert.DeserializeObject<EventMessage>(message);
            if (eventMessage.Action == "UserRegistered")
            {
                // Действия после регистрации пользователя
            }
        }
    }
}
