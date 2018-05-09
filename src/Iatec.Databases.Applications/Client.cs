using System;
using System.Collections.Generic;

namespace Iatec.Databases.Applications
{
    public partial class Client
    {
        public Client()
        {
            ClientLicense = new HashSet<ClientLicense>();
            OrgResponsibles = new HashSet<OrgResponsible>();
            PackageReleases = new HashSet<PackageRelease>();
        }

        public Guid ClientId { get; set; }
        public string UserName { get; set; }
        public string ContactEmail { get; set; }
        public string FirstName { get; set; }
        public bool? IsEmailConfirmed { get; set; }
        public string LastName { get; set; }

        public ICollection<ClientLicense> ClientLicense { get; set; }
        public ICollection<OrgResponsible> OrgResponsibles { get; set; }
        public ICollection<PackageRelease> PackageReleases { get; set; }
    }
}
