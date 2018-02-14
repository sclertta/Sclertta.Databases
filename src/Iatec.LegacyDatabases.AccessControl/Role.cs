
using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.AccessControl
{
    public partial class Role
    {
        public Role()
        {
            Permissions = new HashSet<Permission>();
            RoleConstraints = new HashSet<RoleConstraint>();
            RoleMembers = new HashSet<RoleMember>();
            ChildRoles = new HashSet<Role>();
        }

        public Guid RoleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public Guid? ParentRoleId { get; set; }
        public Guid? ResourceId { get; set; }
        public Guid? AssetId { get; set; }

        public Asset Asset { get; set; }
        public Role ParentRole { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<RoleConstraint> RoleConstraints { get; set; }
        public ICollection<RoleMember> RoleMembers { get; set; }
        public ICollection<Role> ChildRoles { get; set; }
    }
}
