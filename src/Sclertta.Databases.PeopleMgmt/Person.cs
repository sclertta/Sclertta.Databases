using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class Person
    {
        public Person()
        {
            PersonAddress = new HashSet<PersonAddress>();
            PersonDocument = new HashSet<PersonDocument>();
            PersonEcontact = new HashSet<PersonEcontact>();
            PersonPhone = new HashSet<PersonPhone>();
            PersonSystemReference = new HashSet<PersonSystemReference>();
        }

        public Guid PersonId { get; set; }
        public DateTime LastUpdate { get; set; }
        public int PersonStatus { get; set; }
        public Guid? ActivePersonId { get; set; }

        public LegalEntity LegalEntity { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
        public ICollection<PersonAddress> PersonAddress { get; set; }
        public ICollection<PersonDocument> PersonDocument { get; set; }
        public ICollection<PersonEcontact> PersonEcontact { get; set; }
        public ICollection<PersonPhone> PersonPhone { get; set; }
        public ICollection<PersonSystemReference> PersonSystemReference { get; set; }
    }
}
