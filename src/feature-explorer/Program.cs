// See https://aka.ms/new-console-template for more information
//using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
    .Build();

var appSettings = configuration.GetSection("Configurations").Get<Configurations>();

Console.WriteLine($"The value of 'key1' is '{configuration["key1"]}'");
Console.WriteLine($"The value of 'Preview' is '{appSettings?.preview}'");

//     .ConfigureServices((context, services) =>
//     {
//         services.AddFeatureExplorer();
//     })

//var host = Host.CreateDefaultBuilder(args)
//    .ConfigureServices((context, services) =>
//    {
//        services.AddFeatureExplorer();
//    })
//    .Build();
