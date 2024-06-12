namespace CustomerModule.WebAppModule;

 public static class WebApplicationBuilderExtensions
{
    public static void SetupCustomerModule(this IServiceCollection services)
    {
        services.AddTransient<ICustomerHttpClient, CustomerHttpClient>();
        services.Decorate<ICustomerHttpClient, CustomerService>();

        services.AddScoped<LoggingService>();

        services.AddTransient<ICustomerValidator, CustomerValidator>();

    }
}
