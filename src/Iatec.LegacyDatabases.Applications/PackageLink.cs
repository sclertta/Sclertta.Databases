using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Applications
{
    public partial class PackageLink
    {
        public Guid PackageLinkId { get; set; }
        public bool RequirementTypeEnum { get; set; }
        public Guid PackageLinkedId { get; set; }
        public Guid PackageId { get; set; }

        public Package Package { get; set; }
        public Package PackageLinked { get; set; }
    }
}
