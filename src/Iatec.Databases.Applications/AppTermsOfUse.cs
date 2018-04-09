using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppTermsOfUse
    {
        public Guid AppTermsOfUseId { get; set; }
        public Guid AppDomainId { get; set; }
        public Guid RegionalSettingsId { get; set; }
        public int TermsContentTypeEnum { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsCurrent { get; set; }

        public AppDomain AppDomain { get; set; }
        public RegionalSettings RegionalSettings { get; set; }
    }
}
