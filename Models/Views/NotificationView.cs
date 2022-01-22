namespace Notifications;

public class NotificationView : IEntity
{
    public NotificationView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid UserGuid { get; set; }

    public DateTime UtcDate { get; set; }

    public string Message { get; set; }

    public bool IsSeen { get; set; }

    public dynamic RelatedItems { get; set; }
}
