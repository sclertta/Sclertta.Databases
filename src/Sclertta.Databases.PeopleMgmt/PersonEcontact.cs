using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class PersonEcontact
    {
        public Guid PersonEcontactId { get; set; }
        public string Contact { get; set; }
        public string DisplayAs { get; set; }
        public int ContactType { get; set; }
        public Guid PersonId { get; set; }
        public DateTime LastUpdate { get; set; }

        public Person Person { get; set; }
    }
}
