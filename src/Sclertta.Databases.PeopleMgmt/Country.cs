using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class Country
    {
        public Country()
        {
            LocalityType = new HashSet<LocalityType>();
            NaturalPerson = new HashSet<NaturalPerson>();
            NaturalPersonNationality = new HashSet<NaturalPersonNationality>();
            PeopleConfiguration = new HashSet<PeopleConfiguration>();
            PersonAddress = new HashSet<PersonAddress>();
            ZipPostalCodeAddress = new HashSet<ZipPostalCodeAddress>();
        }

        public Guid CountryId { get; set; }
        public string Abbreviation { get; set; }
        public string Code { get; set; }
        public string CultureCode { get; set; }
        public string InternationalCodePhone { get; set; }
        public string Name { get; set; }
        public string NameFemaleNationality { get; set; }
        public string NameMaleNationality { get; set; }

        public ICollection<LocalityType> LocalityType { get; set; }
        public ICollection<NaturalPerson> NaturalPerson { get; set; }
        public ICollection<NaturalPersonNationality> NaturalPersonNationality { get; set; }
        public ICollection<PeopleConfiguration> PeopleConfiguration { get; set; }
        public ICollection<PersonAddress> PersonAddress { get; set; }
        public ICollection<ZipPostalCodeAddress> ZipPostalCodeAddress { get; set; }
    }
}
