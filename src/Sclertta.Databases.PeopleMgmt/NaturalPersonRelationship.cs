using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class NaturalPersonRelationship
    {
        public Guid NaturalPersonRelationshipId { get; set; }
        public Guid NaturalPersonId { get; set; }
        public Guid RelatedId { get; set; }
        public bool? LivesWith { get; set; }
        public int Relationship { get; set; }

        public NaturalPerson NaturalPerson { get; set; }
        public NaturalPerson Related { get; set; }
    }
}
