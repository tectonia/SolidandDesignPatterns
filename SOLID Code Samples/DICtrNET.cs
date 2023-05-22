// Dependency Injection in .NET
// https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection

namespace DependencyInjection.Example;

public interface IMessageWriter
{
    void Write(string message);
}

namespace DependencyInjection.Example;

public class MessageWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine($"MessageWriter.Write(message: \"{message}\")");
    }
}

// This is a separate module in .NET
// It is here where we register the dependencies
// for every request for an IMessageWriter object pass the MessageWriter object
//
var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(
    services =>
        services.AddHostedService<Worker>()
            .AddScoped<IMessageWriter, MessageWriter>());

using var host = builder.Build();

host.Run();

// Now I can use the IMessageWriter interface with many classes knowing my DI framework
// will pass in an instance of MessageWriter every time
public sealed class Worker : BackgroundService
{
    private readonly IMessageWriter _messageWriter;

    public Worker(IMessageWriter messageWriter) =>
        _messageWriter = messageWriter;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _messageWriter.Write($"Worker running at: {DateTimeOffset.Now}");
            await Task.Delay(1_000, stoppingToken);
        }
    }
}