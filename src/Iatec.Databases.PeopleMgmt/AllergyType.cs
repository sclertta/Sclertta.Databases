using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class AllergyType
    {
        public AllergyType()
        {
            NaturalPersonAllergy = new HashSet<NaturalPersonAllergy>();
        }

        public Guid AllergyTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<NaturalPersonAllergy> NaturalPersonAllergy { get; set; }
    }
}
