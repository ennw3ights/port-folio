namespace Infrastructure.Services.DataStore.Common.Services;

public class LoggingService(ISnackbar snackbar, ILogger<LoggingService> logger)
    : ILoggingService
{
    private readonly ISnackbar _snackbar = snackbar;
    private readonly ILogger<LoggingService> _logger = logger;

    public void LogError(string message, Exception exception)
    {
        _logger.LogError(exception, "{Message}: {ExceptionMessage}", message, exception);

        _snackbar.Add(message, Severity.Error);
    }

    public void LogSuccess(string Message)
    {
        _logger.LogInformation("{Message}", Message);

        _snackbar.Add(Message, Severity.Success);
    }
}
