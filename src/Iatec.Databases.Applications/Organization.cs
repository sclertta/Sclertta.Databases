using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class Organization
    {
        public Organization()
        {
            ClientLicense = new HashSet<ClientLicense>();
            OrgResponsibles = new HashSet<OrgResponsible>();
        }

        public Guid OrganizationId { get; set; }
        public string Description { get; set; }
        public string EmailContact { get; set; }
        public string Name { get; set; }

        public ICollection<ClientLicense> ClientLicense { get; set; }
        public ICollection<OrgResponsible> OrgResponsibles { get; set; }
    }
}
