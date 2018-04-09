using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppCategory
    {
        public AppCategory()
        {
            AppDomains = new HashSet<AppDomain>();
        }

        public Guid AppCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AppDomain> AppDomains { get; set; }
    }
}
