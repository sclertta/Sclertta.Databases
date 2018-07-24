using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Rbac
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
