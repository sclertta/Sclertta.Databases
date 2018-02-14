using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class ZipPostalCodeAddress
    {
        public Guid ZipPostalCodeAddress1 { get; set; }
        public Guid CountryId { get; set; }
        public Guid LocalityId { get; set; }
        public string RefNumber { get; set; }
        public string BigUserRefNumber { get; set; }
        public string NeighborhoodRefNumber { get; set; }
        public string ZipPostalCode { get; set; }
        public string AddressLine01 { get; set; }
        public string AddressLine02 { get; set; }
        public string AddressLine03 { get; set; }

        public Country Country { get; set; }
        public Locality Locality { get; set; }
    }
}
