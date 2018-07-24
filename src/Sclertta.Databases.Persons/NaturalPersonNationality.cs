using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class NaturalPersonNationality
    {
        public Guid NaturalPersonNationalityId { get; set; }
        public Guid NaturalPersonId { get; set; }
        public Guid CountryId { get; set; }

        public Country Country { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
    }
}
