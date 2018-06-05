using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class NaturalPersonDisease
    {
        public Guid NaturalPersonDiseaseId { get; set; }
        public Guid DiseaseId { get; set; }
        public Guid NaturalPersonId { get; set; }

        public Disease Disease { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
    }
}
