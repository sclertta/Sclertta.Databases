using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class NotificationUser
    {
        public Guid NotificationUserId { get; set; }
        public Guid? NotificationId { get; set; }
        public bool? IsReaded { get; set; }
        public DateTime? ReadedOnDateTime { get; set; }
        public string UserName { get; set; }

        public Notification Notification { get; set; }
    }
}
