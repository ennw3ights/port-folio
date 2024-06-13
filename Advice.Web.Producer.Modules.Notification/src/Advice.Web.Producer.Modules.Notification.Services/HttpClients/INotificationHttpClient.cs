using Advice.Web.Producer.Modules.Marketing.Services.HttpClients.DTOs;

namespace Advice.Web.Producer.Modules.Marketing.Services.HttpClients;

public interface INotificationHttpClient
{
    Task<NotificationDto> GetAsync(CancellationToken cancellationToken = default);
}