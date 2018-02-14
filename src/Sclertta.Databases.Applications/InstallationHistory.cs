using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class InstallationHistory
    {
        public Guid InstallationHistoryId { get; set; }
        public string InstalledBy { get; set; }
        public DateTime? InstallationDate { get; set; }
        public string ExecutionDetails { get; set; }
        public int? ApplyStatusEnum { get; set; }
        public Guid? PackageId { get; set; }
        public Guid? AppHubId { get; set; }

        public AppHub AppHub { get; set; }
        public Package Package { get; set; }
    }
}
