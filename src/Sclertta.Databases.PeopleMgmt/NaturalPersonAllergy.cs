using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class NaturalPersonAllergy
    {
        public Guid NaturalPersonAllergyId { get; set; }
        public string Description { get; set; }
        public Guid AllergyTypeId { get; set; }
        public Guid NaturalPersonId { get; set; }

        public AllergyType AllergyType { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
    }
}
