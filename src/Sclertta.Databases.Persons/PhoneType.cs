using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            PersonPhone = new HashSet<PersonPhone>();
        }

        public Guid PersonPhoneTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
