using Advice.Web.Producer.Modules.Marketing.Services.HttpClients.DTOs;

namespace Advice.Web.Producer.Modules.Notification.WebAppModule.Components.NotificationCountIcon;

public partial class NotificationCountIconPublicComponent
{
    private static class Mapper
    {
        public static NotificationCountIconComponentModel MapToModel(NotificationDto notificationDto) =>
            new()
            {
                Count = notificationDto.Count,
            };
    }
}