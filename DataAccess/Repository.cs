namespace Notifications;

public class Repository
{
    public static Write<Notifications.Notification> Notification
    {
        get
        {
            return new Write<Notifications.Notification>(new NotificationsContext());
        }
    }

    public static Write<Notifications.NotificationView> NotificationView
    {
        get
        {
            return new Write<Notifications.NotificationView>(new NotificationsContext());
        }
    }
}
