using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Applications
{
    public partial class Notification
    {
        public Notification()
        {
            NotificationUser = new HashSet<NotificationUser>();
        }

        public Guid NotificationId { get; set; }
        public Guid? AppDomainId { get; set; }
        public Guid? AppDeployId { get; set; }
        public Guid? RegionId { get; set; }
        public Guid? InfrastructureId { get; set; }
        public DateTime? BeginDateTime { get; set; }
        public string Code { get; set; }
        public string Contents { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string Groups { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public string Message { get; set; }
        public string ModifiedBy { get; set; }
        public string Users { get; set; }
        public int? ImportanceEnum { get; set; }

        public AppDeploy AppDeploy { get; set; }
        public AppDomain AppDomain { get; set; }
        public Infrastructure Infrastructure { get; set; }
        public Region Region { get; set; }
        public ICollection<NotificationUser> NotificationUser { get; set; }
    }
}
