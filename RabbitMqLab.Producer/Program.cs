using RabbitMQ.Client;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "minha-fila", durable: false, exclusive: false, autoDelete: false, arguments: null);

Console.Write("Digite uma mensagem: ");
string mensagem = Console.ReadLine() ?? "Mensagem vazia";

var body = Encoding.UTF8.GetBytes(mensagem);

channel.BasicPublish(exchange: "", routingKey: "minha-fila", basicProperties: null, body: body);

Console.WriteLine($"✅ Mensagem enviada: {mensagem}");
