namespace Notifications;

public class NotificationBusiness: Business<NotificationView, Notification>
{
    protected override Repository<Notification> WriteRepository => RepositoryNotification;

    protected override ReadRepository<NotificationView> ReadRepository => RepositoryNotificationView;
}
