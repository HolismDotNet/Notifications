using System;

namespace Holism.Notifications.Models
{
    public class Notification : Holism.Models.IEntity
    {
        public Notification()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid UserGuid { get; set; }

        public DateTime UtcDate { get; set; }

        public string Message { get; set; }

        public bool IsSeen { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
