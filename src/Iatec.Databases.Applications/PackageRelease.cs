using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class PackageRelease
    {
        public Guid PackageReleaseId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ReleasedBy { get; set; }
        public Guid? PackageId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? RegionId { get; set; }
        public Guid? AppDeployId { get; set; }
        public string ReleaseNotes { get; set; }

        public AppDeploy AppDeploy { get; set; }
        public Client Client { get; set; }
        public Package Package { get; set; }
        public Region Region { get; set; }
    }
}
