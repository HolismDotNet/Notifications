namespace Notifications;

public class NotificationController : ReadController<NotificationView>
{
    public override ReadBusiness<NotificationView> ReadBusiness => new NotificationBusiness();

    public override Action<ListParameters> ListParametersAugmenter => listParameters =>
    {
        listParameters.AddFilter<NotificationView>(i => i.UserGuid, UserGuid);
    };

    [HttpPost]
    public NotificationView MarkAsSeen(long notificationId)
    {
        return null;
    }
}
