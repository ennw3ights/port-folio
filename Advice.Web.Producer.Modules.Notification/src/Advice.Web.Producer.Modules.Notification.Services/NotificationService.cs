namespace Advice.Web.Producer.Modules.Notification.Services;

public class NotificationService(INotificationHttpClient httpClient) : INotificationHttpClient
{
    public async Task<NotificationDto> GetAsync(CancellationToken cancellationToken = default)
    {
        NotificationDto response = await httpClient.GetAsync(cancellationToken);

        return response;
    }
}
