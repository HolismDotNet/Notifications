using Holism.Api;
using Holism.Business;
using Holism.Notifications.Business;
using Holism.Notifications.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Holism.Infra;

namespace Holism.Notifications.UserApi
{
    public class NotificationController : ReadController<NotificationView>
    {
        public override ReadBusiness<NotificationView> ReadBusiness => new NotificationBusiness();

        public override Action<ListParameters> ListParametersAugmenter => listParameters =>
        {
            listParameters.AddFilter<NotificationView>(i => i.UserGuid, UserGuid);
        };

        [HttpPost]
        public NotificationView MarkAsSeen(long notificationId)
        {
            return null;
        }
    }
}
