using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class AddressType
    {
        public AddressType()
        {
            PersonAddress = new HashSet<PersonAddress>();
        }

        public Guid PersonAddressTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<PersonAddress> PersonAddress { get; set; }
    }
}
