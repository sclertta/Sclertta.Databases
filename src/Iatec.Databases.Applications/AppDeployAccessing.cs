using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppDeployAccessing
    {
        public Guid AppDeployAccessingId { get; set; }
        public string ByUsername { get; set; }
        public DateTime DateAccessed { get; set; }
        public string Browser { get; set; }
        public string Ip { get; set; }
        public Guid AppDeployId { get; set; }
        public string Description { get; set; }
        public int AccessingDeviceEnum { get; set; }

        public AppDeploy AppDeploy { get; set; }
    }
}
