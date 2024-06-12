namespace Advice.Web.Producer.Modules.Notification.Services.HttpClients;

public interface INotificationHttpClient
{
    Task<NotificationDto> GetAsync(CancellationToken cancellationToken = default);
}