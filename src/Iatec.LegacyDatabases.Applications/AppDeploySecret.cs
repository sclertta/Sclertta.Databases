using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Applications
{
    public partial class AppDeploySecret
    {
        public int Id { get; set; }
        public Guid AppDeployId { get; set; }
        public byte[] SecretHash { get; set; }
        public DateTime? Expiration { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }

        public AppDeploy AppDeploy { get; set; }
    }
}
