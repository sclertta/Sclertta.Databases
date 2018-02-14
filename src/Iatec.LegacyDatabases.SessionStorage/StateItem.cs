using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.SessionStorage
{
    public partial class StateItem
    {
        public Guid StateItemId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string UserPrincipal { get; set; }
        public string ContextName { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
