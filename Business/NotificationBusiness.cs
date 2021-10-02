using System;
using System.Linq.Expressions;
using Holism.Business;
using Holism.DataAccess;
using Holism.Infra;
using Holism.Notifications.DataAccess;
using Holism.Notifications.Models;
using Humanizer;

namespace Holism.Notifications.Business
{
    public class NotificationBusiness: Business<NotificationView, Notification>
    {
        protected override Repository<Notification> WriteRepository =>
            Repository.Notification;

        protected override ReadRepository<NotificationView> ReadRepository =>
            Repository.NotificationView;
    }
}