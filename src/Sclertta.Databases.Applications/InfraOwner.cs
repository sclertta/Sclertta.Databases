using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class InfraOwner
    {
        public InfraOwner()
        {
            Infrastructure = new HashSet<Infrastructure>();
        }

        public Guid InfraOwnerId { get; set; }
        public string Name { get; set; }
        public string EmailContact { get; set; }
        public string Description { get; set; }

        public ICollection<Infrastructure> Infrastructure { get; set; }
    }
}
