﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "minha-fila", durable: false, exclusive: false, autoDelete: false, arguments: null);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($"📥 Mensagem recebida: {message}");
};

channel.BasicConsume(queue: "minha-fila", autoAck: true, consumer: consumer);

Console.WriteLine("🕐 Aguardando mensagens. Pressione [Enter] para sair.");
Console.ReadLine();
