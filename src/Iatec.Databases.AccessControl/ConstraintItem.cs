using System;
using System.Collections.Generic;

namespace Iatec.Databases.AccessControl
{
    public partial class ConstraintItem
    {
        public Guid ConstraintItemId { get; set; }
        public string Field { get; set; }
        public string GroupingCode { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public int? LogicOperatorTypeEnum { get; set; }
        public Guid ConstraintDefinitionId { get; set; }
        public int? NumOrder { get; set; }
        public int? Criteria { get; set; }

        public ConstraintDefinition ConstraintDefinition { get; set; }
    }
}
