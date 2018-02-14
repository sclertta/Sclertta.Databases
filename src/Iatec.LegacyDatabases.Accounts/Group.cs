using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Accounts
{
    public partial class Group
    {
        public Group()
        {
            UserGroups = new HashSet<UserGroup>();
            ChildGroups = new HashSet<Group>();
        }

        public Guid GroupId { get; set; }
        public Guid? ParentGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? DomainId { get; set; }

        public PolicyPlace Domain { get; set; }
        public Group ParentGroup { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<Group> ChildGroups { get; set; }
    }
}
