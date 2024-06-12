namespace Infrastructure.Services.DataStore.App.ServiceCollectionExtensions;

public static class ModulesServiceCollections
{
    public static void RegisterModules(this IServiceCollection service)
    {
        service.RegisterAllModules();
    }
}
