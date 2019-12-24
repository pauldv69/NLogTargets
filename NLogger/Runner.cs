using Microsoft.Extensions.Logging;

public class Runner
{
    private readonly ILogger<Runner> _logger;

    public Runner(ILogger<Runner> logger)
    {
        _logger = logger;
        _logger.LogTrace($"{GetType().Name} started.");
    }

    public void DoAction(string name)
    {
        _logger.LogDebug(20, "Doing hard work! {Action}", name);
    }
}