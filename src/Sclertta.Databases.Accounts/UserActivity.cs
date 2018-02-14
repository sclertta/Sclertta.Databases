using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Accounts
{
    public partial class UserActivity
    {
        public Guid UserActivityId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string BrowsingAgent { get; set; }
        public string Description { get; set; }
        public string DevicePlataform { get; set; }
        public string IpAddress { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public Guid? UserId { get; set; }

        public User User { get; set; }
    }
}
