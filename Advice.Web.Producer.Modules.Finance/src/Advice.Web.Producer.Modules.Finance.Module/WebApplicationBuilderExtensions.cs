using Advice.Web.Producer.Modules.Finance.Services;
using Advice.Web.Producer.Modules.Finance.Services.HttpClients;

namespace Advice.Web.Producer.Modules.Finance.Module;

public static class WebApplicationBuilderExtensions
{
    public static void SetupFinanceModule(this IServiceCollection services)
    {
        services.AddTransient<IFinanceHttpClient, FinanceHttpClient>();
        services.Decorate<IFinanceHttpClient, FinanceService>();
    }
}