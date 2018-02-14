using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class DocHostContent
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }

        public DocHostItem IdNavigation { get; set; }
    }
}
