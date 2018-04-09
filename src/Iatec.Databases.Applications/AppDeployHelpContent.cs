using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class AppDeployHelpContent
    {
        public Guid AppDeployHelpContentId { get; set; }
        public string Description { get; set; }
        public string HelpUrlTarget { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid AppDeployHelpId { get; set; }

        public AppDeployHelp AppDeployHelp { get; set; }
    }
}
