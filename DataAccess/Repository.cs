using Holism.Notifications.Models;
using Holism.DataAccess;

namespace Holism.Notifications.DataAccess
{
    public class Repository
    {
        public static Repository<Notification> Notification
        {
            get
            {
                return new Holism.DataAccess.Repository<Notification
                >(new NotificationsContext());
            }
        }

        public static Repository<NotificationView> NotificationView
        {
            get
            {
                return new Holism.DataAccess.Repository<NotificationView
                >(new NotificationsContext());
            }
        }
    }
}
