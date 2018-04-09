using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class Scope
    {
        public Scope()
        {
            AllowedScope = new HashSet<AllowedScope>();
            ScopeSecret = new HashSet<ScopeSecret>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ScopeOldId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<AllowedScope> AllowedScope { get; set; }
        public ICollection<ScopeSecret> ScopeSecret { get; set; }
    }
}
