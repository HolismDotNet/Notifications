using Holism.Api;
using Holism.Business;
using Holism.Notifications.Business;
using Holism.Notifications.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Holism.Infra;

namespace Holism.Notifications.AdminApi
{
    public class NotificationController : ReadController<NotificationView>
    {
        public override ReadBusiness<NotificationView> ReadBusiness => new NotificationBusiness();
    }
}
