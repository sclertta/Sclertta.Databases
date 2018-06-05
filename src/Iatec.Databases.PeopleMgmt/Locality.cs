using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class Locality
    {
        public Locality()
        {
            InverseParent = new HashSet<Locality>();
            NaturalPerson = new HashSet<NaturalPerson>();
            PersonAddress = new HashSet<PersonAddress>();
            ZipPostalCodeAddress = new HashSet<ZipPostalCodeAddress>();
        }

        public Guid LocalityId { get; set; }
        public string Code { get; set; }
        public string RefNumber { get; set; }
        public string ZipPostalCode { get; set; }
        public string Name { get; set; }
        public Guid LocalityTypeId { get; set; }
        public Guid? ParentId { get; set; }
        public string Abbreviation { get; set; }
        public string FormattedName { get; set; }
        public string GeographicLocation { get; set; }
        public string NameFemaleNaturality { get; set; }
        public string NameMaleNaturality { get; set; }
        public double? LatitudeNumber { get; set; }
        public double? LongitudeNumber { get; set; }
        public string TimeZoneInfo { get; set; }
        public bool? IsActive { get; set; }

        public LocalityType LocalityType { get; set; }
        public Locality Parent { get; set; }
        public ICollection<Locality> InverseParent { get; set; }
        public ICollection<NaturalPerson> NaturalPerson { get; set; }
        public ICollection<PersonAddress> PersonAddress { get; set; }
        public ICollection<ZipPostalCodeAddress> ZipPostalCodeAddress { get; set; }
    }
}
