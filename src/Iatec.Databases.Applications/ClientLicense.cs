using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class ClientLicense
    {
        public ClientLicense()
        {
            AppDeploy = new HashSet<AppDeploy>();
        }

        public Guid ClientLicenseId { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? AppDomainId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? DeployCount { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsAuthorized { get; set; }
        public string LicenseKey { get; set; }
        public DateTime? StartDate { get; set; }
        public string UpdatedBy { get; set; }
        public Guid? OrganizationId { get; set; }

        public AppDomain AppDomain { get; set; }
        public Client Client { get; set; }
        public Organization Organization { get; set; }
        public ICollection<AppDeploy> AppDeploy { get; set; }
    }
}
