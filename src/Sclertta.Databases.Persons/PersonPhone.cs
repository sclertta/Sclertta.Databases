using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class PersonPhone
    {
        public Guid PersonPhoneId { get; set; }
        public string CountryAreaCode { get; set; }
        public string CityAreaCode { get; set; }
        public string LocalNumber { get; set; }
        public string Extension { get; set; }
        public Guid PersonId { get; set; }
        public Guid PersonPhoneTypeId { get; set; }
        public bool IsDefault { get; set; }
        public bool IsSmsreceiver { get; set; }
        public DateTime LastUpdate { get; set; }

        public Person Person { get; set; }
        public PhoneType PersonPhoneType { get; set; }
    }
}
