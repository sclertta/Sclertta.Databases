using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Rbac
{
    public partial class ConstraintDefinition
    {
        public ConstraintDefinition()
        {
            ConstraintItems = new HashSet<ConstraintItem>();
            RoleConstraints = new HashSet<RoleConstraint>();
        }

        public Guid ConstraintDefinitionId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public ICollection<ConstraintItem> ConstraintItems { get; set; }
        public ICollection<RoleConstraint> RoleConstraints { get; set; }
    }
}
