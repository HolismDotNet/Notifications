namespace Notifications;

public class NotificationBusiness: Business<NotificationView, Notification>
{
    protected override Write<Notification> Write => Repository.Notification;

    protected override Read<NotificationView> Read => Repository.NotificationView;

    public int GetCount(Guid userGuid)
    {
        var count = GetCount(i => i.UserGuid == userGuid);
        return count;
    }
}
