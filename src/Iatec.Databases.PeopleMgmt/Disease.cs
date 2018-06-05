using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class Disease
    {
        public Disease()
        {
            NaturalPersonDisease = new HashSet<NaturalPersonDisease>();
        }

        public Guid DiseaseId { get; set; }
        public string Cid { get; set; }
        public string Name { get; set; }
        public Guid DiseaseTypeId { get; set; }

        public DiseaseType DiseaseType { get; set; }
        public ICollection<NaturalPersonDisease> NaturalPersonDisease { get; set; }
    }
}
