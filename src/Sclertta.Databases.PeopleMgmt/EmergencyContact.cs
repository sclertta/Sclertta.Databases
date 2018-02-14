using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class EmergencyContact
    {
        public Guid EmergencyContactId { get; set; }
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public string Relationship { get; set; }
        public Guid NaturalPersonId { get; set; }

        public NaturalPerson NaturalPerson { get; set; }
    }
}
