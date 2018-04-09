using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppDeploy
    {
        public AppDeploy()
        {
            AllowedScope = new HashSet<AllowedScope>();
            AppDeployHelp = new HashSet<AppDeployHelp>();
            AppDeploySecret = new HashSet<AppDeploySecret>();
            Notification = new HashSet<Notification>();
            PackageRelease = new HashSet<PackageRelease>();
        }

        public Guid AppDeployId { get; set; }
        public Guid? AppDomainId { get; set; }
        public Guid? LogoImageId { get; set; }
        public Guid? InfrastructureId { get; set; }
        public Guid? RegionId { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string DomainAllowed { get; set; }
        public bool? IsAvailable { get; set; }
        public string MachineThumprint { get; set; }
        public string PublicKey { get; set; }
        public string TechnicalComment { get; set; }
        public string UnavailabilityReason { get; set; }
        public Guid? ClientLicenseId { get; set; }
        public string CreatedBy { get; set; }
        public int SkipRoutesNumForHelp { get; set; }
        public int ShowInDashboard { get; set; }
        public bool AllowOfflineAccess { get; set; }

        public AppDomain AppDomain { get; set; }
        public ClientLicense ClientLicense { get; set; }
        public Infrastructure Infrastructure { get; set; }
        public ImageStorage LogoImage { get; set; }
        public Region Region { get; set; }
        public ICollection<AllowedScope> AllowedScope { get; set; }
        public ICollection<AppDeployHelp> AppDeployHelp { get; set; }
        public ICollection<AppDeploySecret> AppDeploySecret { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<PackageRelease> PackageRelease { get; set; }
    }
}
