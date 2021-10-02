using System;

namespace Holism.Notifications.Models
{
    public class NotificationView : Holism.Models.IEntity
    {
        public NotificationView()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid UserGuid { get; set; }

        public DateTime Date { get; set; }

        public string Message { get; set; }

        public bool IsSeen { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
