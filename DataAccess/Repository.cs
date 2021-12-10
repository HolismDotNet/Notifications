namespace Holism.Notifications.DataAccess;

public class Repository
{
    public static Repository<Notification> Notification
    {
        get
        {
            return new Repository<Notification>(new NotificationsContext());
        }
    }

    public static Repository<NotificationView> NotificationView
    {
        get
        {
            return new Repository<NotificationView>(new NotificationsContext());
        }
    }
}
