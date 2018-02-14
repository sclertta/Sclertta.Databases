using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class AppDomain
    {
        public AppDomain()
        {
            AppDeploy = new HashSet<AppDeploy>();
            AppHub = new HashSet<AppHub>();
            AppTermsOfUse = new HashSet<AppTermsOfUse>();
            ClientLicense = new HashSet<ClientLicense>();
            Notification = new HashSet<Notification>();
            Package = new HashSet<Package>();
            RegionalSettings = new HashSet<RegionalSettings>();
        }

        public Guid AppDomainId { get; set; }
        public Guid? LargeImageId { get; set; }
        public Guid? MediumImageId { get; set; }
        public Guid? SmallImageId { get; set; }
        public Guid? AppCategoryId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string HelpUrl { get; set; }
        public string Name { get; set; }
        public string SerialCode { get; set; }
        public string SignInRelativeUrl { get; set; }
        public string SignOutRelativeUrl { get; set; }
        public string TestRelativeUrl { get; set; }
        public string UserSupportEmail { get; set; }
        public string UserSupportUrl { get; set; }
        public int? AppTypeEnum { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsAuthProvidersAllowed { get; set; }
        public bool IsKeepMeSignedInAllowed { get; set; }
        public bool AllowOtherProblemsInCredRecovery { get; set; }
        public FlowEnum OidcFlowEnum { get; set; }
        public bool IsPublic { get; set; }
        public Guid? AppSolutionId { get; set; }
        public bool UseTermsOfApplication { get; set; }
        public string RenewRelativeUrl { get; set; }

        public AppCategory AppCategory { get; set; }
        public AppSolution AppSolution { get; set; }
        public ImageStorage LargeImage { get; set; }
        public ImageStorage MediumImage { get; set; }
        public ImageStorage SmallImage { get; set; }
        public ICollection<AppDeploy> AppDeploy { get; set; }
        public ICollection<AppHub> AppHub { get; set; }
        public ICollection<AppTermsOfUse> AppTermsOfUse { get; set; }
        public ICollection<ClientLicense> ClientLicense { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<Package> Package { get; set; }
        public ICollection<RegionalSettings> RegionalSettings { get; set; }
    }
}
