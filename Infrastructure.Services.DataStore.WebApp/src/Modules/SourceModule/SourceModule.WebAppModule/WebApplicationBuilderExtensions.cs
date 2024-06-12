namespace SourceModule.WebAppModule;

public static class WebApplicationBuilderExtensions
{
    public static void SetupSourceModule(this IServiceCollection services)
    {
        services.AddTransient<ISourceHttpClient, SourceHttpClient>();
        services.Decorate<ISourceHttpClient, SourceService>();

        services.AddTransient<ISourceValidator, SourceValidator>();
    }
}
