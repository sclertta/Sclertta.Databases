using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class NaturalPerson
    {
        public NaturalPerson()
        {
            EmergencyContact = new HashSet<EmergencyContact>();
            NaturalPersonAllergy = new HashSet<NaturalPersonAllergy>();
            NaturalPersonDisability = new HashSet<NaturalPersonDisability>();
            NaturalPersonDisease = new HashSet<NaturalPersonDisease>();
            NaturalPersonHealthPlan = new HashSet<NaturalPersonHealthPlan>();
            NaturalPersonMedicine = new HashSet<NaturalPersonMedicine>();
            NaturalPersonNationality = new HashSet<NaturalPersonNationality>();
            NaturalPersonRelationshipNaturalPerson = new HashSet<NaturalPersonRelationship>();
            NaturalPersonRelationshipRelated = new HashSet<NaturalPersonRelationship>();
            NaturalPersonSimilarMainNaturalPerson = new HashSet<NaturalPersonSimilar>();
            NaturalPersonSimilarSimilarNaturalPerson = new HashSet<NaturalPersonSimilar>();
        }

        public Guid NaturalPersonId { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeceaseDate { get; set; }
        public DateTime? BaptismDate { get; set; }
        public Guid? ReligionId { get; set; }
        public Guid? MaritalStatusId { get; set; }
        public Guid? BirthCityId { get; set; }
        public Guid? EthnicityId { get; set; }
        public int Gender { get; set; }
        public Guid? Photo { get; set; }
        public Guid? OccupationId { get; set; }
        public string LastName { get; set; }
        public int? BloodType { get; set; }
        public string MiddleName { get; set; }
        public string AuthenticationUserName { get; set; }
        public string FullName { get; set; }
        public Guid? ScholarityId { get; set; }
        public string PhoneticFullName { get; set; }
        public Guid? BirthCountryId { get; set; }
        public string MotherName { get; set; }
        public string SocialName { get; set; }

        public Locality BirthCity { get; set; }
        public Country BirthCountry { get; set; }
        public Ethnicity Ethnicity { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Person NaturalPersonNavigation { get; set; }
        public Occupation Occupation { get; set; }
        public Religion Religion { get; set; }
        public Scholarity Scholarity { get; set; }
        public ICollection<EmergencyContact> EmergencyContact { get; set; }
        public ICollection<NaturalPersonAllergy> NaturalPersonAllergy { get; set; }
        public ICollection<NaturalPersonDisability> NaturalPersonDisability { get; set; }
        public ICollection<NaturalPersonDisease> NaturalPersonDisease { get; set; }
        public ICollection<NaturalPersonHealthPlan> NaturalPersonHealthPlan { get; set; }
        public ICollection<NaturalPersonMedicine> NaturalPersonMedicine { get; set; }
        public ICollection<NaturalPersonNationality> NaturalPersonNationality { get; set; }
        public ICollection<NaturalPersonRelationship> NaturalPersonRelationshipNaturalPerson { get; set; }
        public ICollection<NaturalPersonRelationship> NaturalPersonRelationshipRelated { get; set; }
        public ICollection<NaturalPersonSimilar> NaturalPersonSimilarMainNaturalPerson { get; set; }
        public ICollection<NaturalPersonSimilar> NaturalPersonSimilarSimilarNaturalPerson { get; set; }
    }
}
