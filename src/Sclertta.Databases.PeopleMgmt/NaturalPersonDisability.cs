using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class NaturalPersonDisability
    {
        public Guid NaturalPersonDisabilityId { get; set; }
        public Guid DisabilityTypeId { get; set; }
        public Guid NaturalPersonId { get; set; }

        public DisabilityType DisabilityType { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
    }
}
