// See https://aka.ms/new-console-template for more information
//using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.FeatureManagement;

Console.WriteLine("Hello, World!");

// Configuration
IConfiguration configuration = new ConfigurationBuilder()
  .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
  .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
  .Build();

// Services with DI
IServiceCollection services_already = new ServiceCollection();
services_already.AddLogging();
services_already.AddTransient<IMyClass, MyClass>();

var appSettings = configuration.GetSection("Configurations").Get<Configurations>();

Console.WriteLine($"The value of 'key1' is '{configuration["key1"]}'");
Console.WriteLine($"The value of 'Preview' is '{appSettings?.preview}'");

var host = Host.CreateDefaultBuilder(args)
  .ConfigureAppConfiguration((hostingContext, config) =>
      {
      config.AddConfiguration(configuration);
      })
  .ConfigureServices((hostContext, services) => {
    services.AddLogging();
    services.AddTransient<IMyClass, MyClass>();
    services.AddFeatureManagement();
    })
  .ConfigureLogging(logging => {
      logging.AddConsole();
      })
  .Build();

var logger = host.Services.GetRequiredService<ILogger<Program>>();
IMyClass myClass = host.Services.GetRequiredService<IMyClass>();
myClass.MyMethod();

logger.LogInformation("This is an informational message.");
logger.LogInformation("This is an informational message for {name}.", nameof(logger));

var feature_manager = host.Services.GetRequiredService<IFeatureManager>();
var enabledA = await feature_manager.IsEnabledAsync("FeatureA");
var enabledB = await feature_manager.IsEnabledAsync("FeatureB");

logger.LogInformation("The feature FeatureA is enabled: {enabled}", enabledA);
logger.LogInformation("The feature FeatureB is enabled: {enabled}", enabledB);

host.Run();
