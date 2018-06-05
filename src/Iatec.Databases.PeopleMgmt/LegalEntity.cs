using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class LegalEntity
    {
        public Guid LegalEntityId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public bool IsAdventistEntity { get; set; }
        public string Acronym { get; set; }
        public string RegionCode { get; set; }
        public string TimeZoneInfoId { get; set; }
        public Guid? HierarchyNodeId { get; set; }
        public Guid CountryId { get; set; }
        public string PhoneticName { get; set; }

        public Person LegalEntityNavigation { get; set; }
    }
}
