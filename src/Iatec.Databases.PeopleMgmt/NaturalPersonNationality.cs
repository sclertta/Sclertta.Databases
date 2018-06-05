using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
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
