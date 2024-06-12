namespace Infrastructure.Services.DataStore.Search.WebAppModule;

public static class WebApplicationBuilderExtensions
{
    public static void SetupSearchModule(this IServiceCollection services)
    {
        services.AddTransient<ISearchHttpClient, SearchHttpClient>();
        services.Decorate<ISearchHttpClient, SearchService>();
    }
}
