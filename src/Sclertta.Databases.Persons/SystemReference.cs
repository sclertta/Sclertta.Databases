using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class SystemReference
    {
        public Guid SystemReferenceId { get; set; }
        public DateTime BeginUseDate { get; set; }
        public Guid EntityId { get; set; }
        public Guid SystemClientId { get; set; }

        public SystemClient SystemClient { get; set; }
    }
}
