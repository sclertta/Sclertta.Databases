using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Applications
{
    public partial class Client
    {
        public Client()
        {
            ClientLicense = new HashSet<ClientLicense>();
            OrgResponsible = new HashSet<OrgResponsible>();
            PackageRelease = new HashSet<PackageRelease>();
        }

        public Guid ClientId { get; set; }
        public string UserName { get; set; }
        public string ContactEmail { get; set; }
        public string FirstName { get; set; }
        public bool? IsEmailConfirmed { get; set; }
        public string LastName { get; set; }

        public ICollection<ClientLicense> ClientLicense { get; set; }
        public ICollection<OrgResponsible> OrgResponsible { get; set; }
        public ICollection<PackageRelease> PackageRelease { get; set; }
    }
}
