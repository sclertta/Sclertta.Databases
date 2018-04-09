using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class RegionalSettings
    {
        public RegionalSettings()
        {
            AppTermsOfUse = new HashSet<AppTermsOfUse>();
        }

        public Guid RegionalSettingsId { get; set; }
        public Guid? AppDomainId { get; set; }
        public Guid? RegionId { get; set; }
        public string SupportEmail { get; set; }
        public string SupportUrl { get; set; }
        public string TermsAndPrivacyUrl { get; set; }

        public AppDomain AppDomain { get; set; }
        public Region Region { get; set; }
        public ICollection<AppTermsOfUse> AppTermsOfUse { get; set; }
    }
}
