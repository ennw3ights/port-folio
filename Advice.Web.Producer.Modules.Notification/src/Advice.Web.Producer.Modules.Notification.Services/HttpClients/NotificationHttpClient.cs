namespace Advice.Web.Producer.Modules.Notification.Services.HttpClients;

public class NotificationHttpClient() : INotificationHttpClient
{
    //Пока что стоит заглушка, поэтому предупреждение игнорируется
    public async Task<NotificationDto> GetAsync(CancellationToken cancellationToken = default)
    {
        await Task.Delay(100, cancellationToken);

        var notificationDto = new NotificationDto()
        {
            Count = 70,
        };

        return notificationDto;
    }
}
