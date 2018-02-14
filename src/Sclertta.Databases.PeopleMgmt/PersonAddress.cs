using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class PersonAddress
    {
        public Guid PersonAddressId { get; set; }
        public string AddressLine01 { get; set; }
        public string AddressLine02 { get; set; }
        public Guid PersonId { get; set; }
        public Guid PersonAddressTypeId { get; set; }
        public string ZipPostalCode { get; set; }
        public bool? IsMailingAddress { get; set; }
        public Guid? LocalityId { get; set; }
        public DateTime LastUpdate { get; set; }
        public string AddressNumber { get; set; }
        public Guid CountryId { get; set; }
        public string OtherLocality { get; set; }
        public string AddressLine03 { get; set; }

        public Country Country { get; set; }
        public Locality Locality { get; set; }
        public Person Person { get; set; }
        public AddressType PersonAddressType { get; set; }
    }
}
