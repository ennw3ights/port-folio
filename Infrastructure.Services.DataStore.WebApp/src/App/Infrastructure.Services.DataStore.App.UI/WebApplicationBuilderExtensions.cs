using Infrastructure.Services.DataStore.Customer.WebAppModule;
using SourceModule.WebAppModule;


namespace Infrastructure.Services.DataStore.App.UI;

public static class WebApplicationBuilderExtensions
{
    public static void RegisterAllModules(this IServiceCollection service)
    {
        service.SetupSourceModule();
        service.SetupCustomerModule();
    }
}
