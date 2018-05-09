using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppSolution
    {
        public AppSolution()
        {
            AppDomains = new HashSet<AppDomain>();
        }

        public Guid AppSolutionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AppDomain> AppDomains { get; set; }
    }
}
