using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class PackageType
    {
        public PackageType()
        {
            Packages = new HashSet<Package>();
        }

        public Guid PackageTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? PackageTypeImportanceEnum { get; set; }
        public int? BackupTypeEnum { get; set; }

        public ICollection<Package> Packages { get; set; }
    }
}
