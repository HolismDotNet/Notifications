using System.Collections.Generic;
using Holism.Notifications.Models;
using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Holism.Notifications.DataAccess
{
    public class NotificationsContext : DatabaseContext
    {
        public override string ConnectionStringName => "Notifications";

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<NotificationView> NotificationViews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
