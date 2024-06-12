namespace Infrastructure.Services.DataStore.App.BuilderExtensions;

public static class SharedServicesBuilderExtension
{
    public static void RegisterSharedServices(
        this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ILoggingService, LoggingService>();
    }
}
