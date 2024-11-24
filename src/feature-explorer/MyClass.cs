using Microsoft.Extensions.Logging;

public class MyClass : IMyClass
{
    private readonly ILogger<MyClass> _logger;

    public MyClass(ILogger<MyClass> logger)
    {
        _logger = logger;
    }

    public void MyMethod()
    {
        _logger.LogInformation("This is an informational message.");
        _logger.LogWarning("This is a warning message.");
        _logger.LogError("This is an error message.");
    }
}
