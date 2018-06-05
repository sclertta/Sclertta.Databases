using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class ZipPostalCodeAddressImportLog
    {
        public Guid ZipPostalCodeAddressImportLogId { get; set; }
        public string Note { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int Type { get; set; }
    }
}
