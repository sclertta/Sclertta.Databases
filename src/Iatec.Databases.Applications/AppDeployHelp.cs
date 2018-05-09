using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppDeployHelp
    {
        public AppDeployHelp()
        {
            AppDeployHelpContents = new HashSet<AppDeployHelpContent>();
            InverseParentAppDeployHelps = new HashSet<AppDeployHelp>();
        }

        public Guid AppDeployHelpId { get; set; }
        public string UrlCaught { get; set; }
        public string RelativeUrl { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid AppDeployId { get; set; }
        public Guid? ParentAppDeployHelpId { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Name { get; set; }

        public AppDeploy AppDeploy { get; set; }
        public AppDeployHelp ParentAppDeployHelp { get; set; }
        public ICollection<AppDeployHelpContent> AppDeployHelpContents { get; set; }
        public ICollection<AppDeployHelp> InverseParentAppDeployHelps { get; set; }
    }
}
