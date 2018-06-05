using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class DiseaseType
    {
        public DiseaseType()
        {
            Disease = new HashSet<Disease>();
        }

        public Guid DiseaseTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Disease> Disease { get; set; }
    }
}
