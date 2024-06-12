namespace Infrastructure.Services.DataStore.App.BuilderExtensions;

public static class CommonServicesBuilderExtension
{
    public static void RegisterCommonServices(
        this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<ILoggingService, LoggingService>();
    }
}
