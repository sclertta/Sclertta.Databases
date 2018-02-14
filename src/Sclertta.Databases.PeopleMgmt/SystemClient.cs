using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class SystemClient
    {
        public SystemClient()
        {
            PersonSystemReference = new HashSet<PersonSystemReference>();
            SystemReference = new HashSet<SystemReference>();
        }

        public Guid SystemClientId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Guid? SystemClientApiId { get; set; }

        public ICollection<PersonSystemReference> PersonSystemReference { get; set; }
        public ICollection<SystemReference> SystemReference { get; set; }
    }
}
