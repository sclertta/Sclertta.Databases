﻿using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class PackageType
    {
        public PackageType()
        {
            Package = new HashSet<Package>();
        }

        public Guid PackageTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? PackageTypeImportanceEnum { get; set; }
        public int? BackupTypeEnum { get; set; }

        public ICollection<Package> Package { get; set; }
    }
}
