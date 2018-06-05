using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class DocHostItem
    {
        public int Id { get; set; }
        public string Guid { get; set; }

        public DocHostContent DocHostContent { get; set; }
    }
}
