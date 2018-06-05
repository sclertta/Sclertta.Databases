using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class PersonSystemReference
    {
        public PersonSystemReference()
        {
            LegalEntitySystemUpdate = new HashSet<LegalEntitySystemUpdate>();
            NaturalPersonSystemUpdate = new HashSet<NaturalPersonSystemUpdate>();
        }

        public Guid PersonSystemReferenceId { get; set; }
        public Guid SystemClientId { get; set; }
        public Guid PersonId { get; set; }
        public int SystemUseStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Person Person { get; set; }
        public SystemClient SystemClient { get; set; }
        public ICollection<LegalEntitySystemUpdate> LegalEntitySystemUpdate { get; set; }
        public ICollection<NaturalPersonSystemUpdate> NaturalPersonSystemUpdate { get; set; }
    }
}
