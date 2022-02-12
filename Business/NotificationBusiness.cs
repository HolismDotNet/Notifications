namespace Notifications;

public class NotificationBusiness: Business<NotificationView, Notification>
{
    protected override Write<Notification> Write => Repository.Notification;

    protected override Read<NotificationView> Read => Repository.NotificationView;
}
