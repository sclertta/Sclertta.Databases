using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Accounts
{
    public partial class UserGroup
    {
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
        public Guid UserGroupId { get; set; }

        public Group Group { get; set; }
        public User User { get; set; }
    }
}
