namespace Notifications;

public class NotificationBusiness: Business<NotificationView, Notification>
{
    protected override Repository<Notification> WriteRepository => Repository.Notification;

    protected override ReadRepository<NotificationView> ReadRepository => Repository.NotificationView;
}
