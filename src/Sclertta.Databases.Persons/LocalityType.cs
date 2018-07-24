using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class LocalityType
    {
        public LocalityType()
        {
            Locality = new HashSet<Locality>();
        }

        public Guid LocalityTypeId { get; set; }
        public string Code { get; set; }
        public string FormattedNameMask { get; set; }
        public bool HasAddress { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public Guid CountryId { get; set; }
        public int PoliticalDivisionType { get; set; }

        public Country Country { get; set; }
        public ICollection<Locality> Locality { get; set; }
    }
}
