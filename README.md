# ⚡ Integrating Redis with .NET Aspire

This repository showcases how to integrate **Redis** with **.NET Aspire**, a cutting-edge framework by Microsoft for building and running cloud-native applications in .NET.

## 🧠 What is .NET Aspire?

[.NET Aspire](https://devblogs.microsoft.com/dotnet/introducing-dotnet-aspire/) simplifies the process of creating distributed systems using best practices in observability, service discovery, cloud-native patterns, and more.

## 🧰 Why Redis?

[Redis](https://redis.io/) is a lightning-fast, in-memory data store widely used for caching, pub/sub, session storage, and more. Integrating Redis into a .NET Aspire project enhances performance, scalability, and responsiveness.

## 📘 Step-by-Step Guide

A complete guide is available on our blog:

👉 [How to Integrate .NET Aspire with Redis](https://tutexchange.com/how-to-integrate-net-aspire-with-redis/)

The article walks through:
- Adding Redis support in Aspire using `RedisContainerResource`
- Using `StackExchange.Redis` in your .NET project
- Registering Redis services via Aspire's builder extensions
- Implementing simple cache logic

## 🔧 Tech Stack

- [.NET Aspire](https://github.com/dotnet/aspire)
- ASP.NET Core
- Redis
- Docker
- StackExchange.Redis

## 🏁 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Docker](https://www.docker.com/)
- [StackExchange.Redis](https://www.nuget.org/packages/StackExchange.Redis/)

### Running the Project

1. Clone this repo:
   ```bash
   git clone https://github.com/saineshwar/Aspire_Redis.git
   cd aspire-redis-integration
