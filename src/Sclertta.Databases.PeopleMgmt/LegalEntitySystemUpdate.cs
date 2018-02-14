using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class LegalEntitySystemUpdate
    {
        public Guid LegalEntitySystemUpdateId { get; set; }
        public DateTime LastUpdate { get; set; }
        public Guid PersonSystemReferenceId { get; set; }
        public int LegalEntityEntityType { get; set; }

        public PersonSystemReference PersonSystemReference { get; set; }
    }
}
