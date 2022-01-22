namespace Notifications;

public class Repository
{
    public static Repository<Notifications.Notification> Notification
    {
        get
        {
            return new Repository<Notifications.Notification>(new NotificationsContext());
        }
    }

    public static Repository<Notifications.NotificationView> NotificationView
    {
        get
        {
            return new Repository<Notifications.NotificationView>(new NotificationsContext());
        }
    }
}
