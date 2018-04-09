using System;
using System.Collections.Generic;

namespace Iatec.Databases.AccessControl
{
    public partial class RoleConstraint
    {
        public Guid RoleConstraintId { get; set; }
        public Guid RoleId { get; set; }
        public Guid ConstraintDefinitionId { get; set; }

        public ConstraintDefinition ConstraintDefinition { get; set; }
        public Role Role { get; set; }
    }
}
