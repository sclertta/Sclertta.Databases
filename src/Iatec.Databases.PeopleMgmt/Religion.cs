using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class Religion
    {
        public Religion()
        {
            NaturalPerson = new HashSet<NaturalPerson>();
        }

        public Guid ReligionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<NaturalPerson> NaturalPerson { get; set; }
    }
}
