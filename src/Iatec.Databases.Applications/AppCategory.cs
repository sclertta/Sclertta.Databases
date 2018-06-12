using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppCategory
    {
        public AppCategory()
        {
            AppDomain = new HashSet<AppDomain>();
        }

        public Guid AppCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AppDomain> AppDomain { get; set; }
    }
}
