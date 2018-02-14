using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Accounts
{
    public partial class User
    {
        public User()
        {
            UserActivities = new HashSet<UserActivity>();
            UserGroups = new HashSet<UserGroup>();
        }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Uid { get; set; }
        public bool? IsApproved { get; set; }
        public string Email { get; set; }
        public Guid? DomainId { get; set; }
        public Guid? LocationId { get; set; }
        public int? ProviderEnum { get; set; }
        public bool IsRegistrationCompleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }

        public PolicyPlace Domain { get; set; }
        public Location Location { get; set; }
        public ICollection<UserActivity> UserActivities { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
    }
}
