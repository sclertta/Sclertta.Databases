using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class NaturalPersonSystemUpdate
    {
        public Guid NaturalPersonSystemUpdateId { get; set; }
        public DateTime LastUpdate { get; set; }
        public Guid PersonSystemReferenceId { get; set; }
        public int NaturalPersonEntityType { get; set; }

        public PersonSystemReference PersonSystemReference { get; set; }
    }
}
