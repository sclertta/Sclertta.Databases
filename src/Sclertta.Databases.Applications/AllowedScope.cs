using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class AllowedScope
    {
        public int Id { get; set; }
        public Guid AppDeployId { get; set; }
        public string ScopeOldId { get; set; }
        public int ScopeId { get; set; }

        public AppDeploy AppDeploy { get; set; }
        public Scope Scope { get; set; }
    }
}
