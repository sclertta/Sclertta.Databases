using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class ExecutionType
    {
        public ExecutionType()
        {
            FileContents = new HashSet<FileContent>();
        }

        public Guid ExecutionTypeId { get; set; }
        public string Name { get; set; }
        public string TypeFullName { get; set; }
        public string FileExtension { get; set; }
        public string Icon { get; set; }
        public bool IsDefault { get; set; }

        public ICollection<FileContent> FileContents { get; set; }
    }
}
