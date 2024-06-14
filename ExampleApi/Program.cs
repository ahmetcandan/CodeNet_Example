using Autofac;
using CodeNet.Container.Module;
using CodeNet.Extensions;
using CodeNet.MongoDB.Module;
using CodeNet.RabbitMQ.Module;
using ExampleApi.Handler;
using ExampleApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseNetCoreContainer(containerBuilder =>
{
    containerBuilder.RegisterModule<MediatRModule<MongoDBGetValueRequestHandler>>();
    containerBuilder.RegisterModule<MongoDBModule>();
    containerBuilder.RegisterModule<RabbitMQProducerModule<QueueModel>>();
    containerBuilder.RegisterModule<RabbitMQConsumerModule<QueueModel>>();
});
builder.AddNetCore("Application");
builder.AddMongoDB("MongoDB");
builder.AddRedisDistributedCache("Redis");
builder.AddRedisDistributedLock("Redis");
builder.AddAuthentication("Identity");

var app = builder.Build();

app.UseNetCore(builder.Configuration, "Application");
app.Run();
