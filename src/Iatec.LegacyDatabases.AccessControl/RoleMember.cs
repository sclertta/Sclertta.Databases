using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.AccessControl
{
    public partial class RoleMember
    {
        public Guid RoleMemberId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Subject { get; set; }
        public int? SubjectTypeEnum { get; set; }
        public Guid RoleId { get; set; }

        public Role Role { get; set; }
    }
}
