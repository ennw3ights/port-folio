using Advice.Web.Producer.Modules.Marketing.Services;
using Advice.Web.Producer.Modules.Marketing.Services.HttpClients;

namespace Advice.Web.Producer.Modules.Notification.WebAppModule;

public static class WebApplicationBuilderExtensions
{
    public static void SetupNotificationModule(this IServiceCollection services)
    {
        services.AddTransient<INotificationHttpClient, NotificationHttpClient>();

        services.Decorate<INotificationHttpClient, NotificationService>();
    }
}