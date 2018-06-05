using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class DisabilityType
    {
        public DisabilityType()
        {
            NaturalPersonDisability = new HashSet<NaturalPersonDisability>();
        }

        public Guid DisabilityTypeId { get; set; }
        public string Name { get; set; }
        public string DisabilityGovernmentCode { get; set; }

        public ICollection<NaturalPersonDisability> NaturalPersonDisability { get; set; }
    }
}
