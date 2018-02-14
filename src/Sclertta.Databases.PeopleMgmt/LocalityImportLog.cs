using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class LocalityImportLog
    {
        public Guid LocalityImportLogId { get; set; }
        public string Note { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int Type { get; set; }
    }
}
