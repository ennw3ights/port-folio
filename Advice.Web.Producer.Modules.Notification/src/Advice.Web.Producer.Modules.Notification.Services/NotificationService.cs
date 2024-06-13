using Advice.Web.Producer.Modules.Marketing.Services.HttpClients;
using Advice.Web.Producer.Modules.Marketing.Services.HttpClients.DTOs;

namespace Advice.Web.Producer.Modules.Marketing.Services;

public class NotificationService(INotificationHttpClient httpClient) : INotificationHttpClient
{
    public async Task<NotificationDto> GetAsync(CancellationToken cancellationToken = default)
    {
        NotificationDto response = await httpClient.GetAsync(cancellationToken);

        return response;
    }
}
