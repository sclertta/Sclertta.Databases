using System;
using System.Collections.Generic;

namespace Iatec.Databases.PeopleMgmt
{
    public partial class DocHostContent
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }

        public DocHostItem IdNavigation { get; set; }
    }
}
