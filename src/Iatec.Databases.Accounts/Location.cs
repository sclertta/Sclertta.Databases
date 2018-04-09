using System;
using System.Collections.Generic;

namespace Iatec.Databases.Accounts
{
    public partial class Location
    {
        public Location()
        {
            Users = new HashSet<User>();
        }

        public Guid LocationId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PhonePrefix { get; set; }
        public Guid? RegionId { get; set; }
        public string TimeZoneId { get; set; }

        public PolicyPlace Region { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
