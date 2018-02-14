using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class AppSolution
    {
        public AppSolution()
        {
            AppDomain = new HashSet<AppDomain>();
        }

        public Guid AppSolutionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AppDomain> AppDomain { get; set; }
    }
}
