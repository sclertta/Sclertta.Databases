using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Applications
{
    public partial class OrgResponsible
    {
        public Guid OrgResponsibleId { get; set; }
        public bool IsActive { get; set; }
        public Guid OrganizationId { get; set; }
        public Guid ClientId { get; set; }

        public Client Client { get; set; }
        public Organization Organization { get; set; }
    }
}
