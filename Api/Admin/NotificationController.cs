namespace Notifications;

public class NotificationController : ReadController<NotificationView>
{
    public override ReadBusiness<NotificationView> ReadBusiness => new NotificationBusiness();
}
