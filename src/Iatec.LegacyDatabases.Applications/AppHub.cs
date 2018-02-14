using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Applications
{
    public partial class AppHub
    {
        public AppHub()
        {
            InstallationHistory = new HashSet<InstallationHistory>();
        }

        public Guid AppHubId { get; set; }
        public Guid? AppDomainId { get; set; }
        public string Name { get; set; }
        public string DataConnectionString { get; set; }
        public string RootFolder { get; set; }
        public string DataBackupFolder { get; set; }
        public string RootBackupFolder { get; set; }
        public int? HubTypeEnum { get; set; }

        public AppDomain AppDomain { get; set; }
        public ICollection<InstallationHistory> InstallationHistory { get; set; }
    }
}
