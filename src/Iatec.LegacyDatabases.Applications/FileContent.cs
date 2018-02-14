using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Applications
{
    public partial class FileContent
    {
        public Guid FileContentId { get; set; }
        public int? ExecutionOrder { get; set; }
        public string FileName { get; set; }
        public string Name { get; set; }
        public string RelativePath { get; set; }
        public string TargetParams { get; set; }
        public Guid? ExecutionTypeId { get; set; }
        public Guid? PackageId { get; set; }

        public ExecutionType ExecutionType { get; set; }
        public Package Package { get; set; }
    }
}
