using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class DocHostItem
    {
        public int Id { get; set; }
        public string Guid { get; set; }

        public DocHostContent DocHostContent { get; set; }
    }
}
