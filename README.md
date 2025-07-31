# 🐇 RabbitMqLab (.NET + RabbitMQ)

Este projeto demonstra o uso de mensageria com **RabbitMQ** em aplicações .NET. Ele está separado em dois projetos:

- ✅ `RabbitMqLab.Producer`: envia mensagens para uma fila
- ✅ `RabbitMqLab.Consumer`: consome mensagens da fila e as processa

---

## 🧰 Tecnologias utilizadas

- [.NET 9](https://dotnet.microsoft.com/)
- [RabbitMQ](https://www.rabbitmq.com/)
- Docker (para subir o broker RabbitMQ localmente)
- [RabbitMQ.Client](https://www.nuget.org/packages/RabbitMQ.Client/)

---

## 📁 Estrutura do projeto

RabbitMqLab/
├── RabbitMqLab.Producer/ # Envia mensagens
├── RabbitMqLab.Consumer/ # Escuta e consome mensagens
└── RabbitMqLab.sln # Solution principal

---

## 🚀 Como executar localmente

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/RabbitMqLab.git
cd RabbitMqLab

