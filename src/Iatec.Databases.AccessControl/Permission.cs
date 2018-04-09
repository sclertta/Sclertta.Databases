using System;
using System.Collections.Generic;

namespace Iatec.Databases.AccessControl
{
    public partial class Permission
    {
        public Guid PermissionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? PermissionTypeEnum { get; set; }
        public Guid RoleId { get; set; }
        public Guid? ResourceId { get; set; }
        public Guid? AssetId { get; set; }

        public Asset Asset { get; set; }
        public Role Role { get; set; }
    }
}
